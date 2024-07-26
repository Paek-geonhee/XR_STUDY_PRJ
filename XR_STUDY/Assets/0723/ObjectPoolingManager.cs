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
            // ��ųʸ� ���� Ű���� �ش��ϴ� ���� �����ϴ°�?
            objectDB.Add(objName, new List<GameObject>());
            // ���ٸ� �ش� Ű���� �ش��ϴ� ���� ������.
        }
        var foundObj = objectDB[objName].FirstOrDefault(obj => !obj.activeInHierarchy);
        // �����ͺ��̽� ���ο� Ư�� ����Ʈ���� ��Ȱ�� ������ � ó������ �νĵǴ� ������Ʈ�� ��ȯ��.

        if (!foundObj) { 
            // Ȥ�ó� ��Ȱ�� ������ ������Ʈ�� Ǯ�� ���ο� ���ٸ� ���ο� ������Ʈ ���� �� Ǯ���� �߰�
            var newObj = Instantiate(poolingObjects.FirstOrDefault(obj => obj.name == objName).prefab);
            objectDB[objName].Add(newObj);

            foundObj = newObj;
        }
        
        foundObj.SetActive(true);
        return foundObj;


        // �������ڸ�, ������Ʈ ��û ��, ������Ʈ Ǯ�� ���ο� ��Ȱ�� ��Ұ� ������ ��� �׷� ��Ҹ� �������� ������ ��ȯ��.
        // ��Ȱ�� ��Ұ� ���ٸ� ���� �����Ͽ� ������Ʈ Ǯ�� ���ο� ������ �� �ش� ������Ʈ�� ��ȯ��.
    }
}
