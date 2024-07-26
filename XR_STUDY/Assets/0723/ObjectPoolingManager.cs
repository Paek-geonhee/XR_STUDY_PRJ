using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPoolingManager : MonoBehaviour
{
    private static ObjectPoolingManager instance;
    public static ObjectPoolingManager Instance { get {
            if (instance == null) {
                instance = FindAnyObjectByType<ObjectPoolingManager>();
            }
            if (instance == null) {
                var go = new GameObject(nameof(ObjectPoolingManager));
                instance = go.AddComponent<ObjectPoolingManager>();
            }
            return instance;
        } 
    }

    public PoolingObject[] poolingObjects;

    private Dictionary<string, List<GameObject>> objectDB;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else { 
            Destroy(gameObject);
        }

    }

    private void Start()
    {
        
        foreach (var poolingObject in poolingObjects)
        {
            var obj = Get(poolingObject.name);
            obj.SetActive(false);
        }
    }
    public GameObject Get(string objName) {
        objectDB ??= new Dictionary<string, List<GameObject>>();

        if (!objectDB.ContainsKey(objName)) { 
            // 딕셔너리 내부 키값에 해당하는 값이 존재하는가?
            objectDB.Add(objName, new List<GameObject>());
            // 없다면 해당 키값에 해당하는 값을 생성함.
        }
        var foundObj = objectDB[objName].FirstOrDefault(obj => !obj.activeInHierarchy);
        // 데이터베이스 내부에 특정 리스트에서 비활성 상태인 어떤 처음으로 인식되는 오브젝트를 반환함.

        if (!foundObj) { 
            // 혹시나 비활성 상태인 오브젝트가 풀링 내부에 없다면 새로운 오브젝트 생성 후 풀링에 추가
            var newObj = Instantiate(poolingObjects.FirstOrDefault(obj => obj.name == objName).prefab);
            objectDB[objName].Add(newObj);

            foundObj = newObj;
        }
        
        foundObj.SetActive(true);
        return foundObj;


        // 정리하자면, 오브젝트 요청 시, 오브젝트 풀링 내부에 비활성 요소가 존재할 경우 그런 요소를 무작위로 선택해 반환함.
        // 비활성 요소가 없다면 새로 생성하여 오브젝트 풀링 내부에 삽입한 뒤 해당 오브젝트를 반환함.
    }
}
