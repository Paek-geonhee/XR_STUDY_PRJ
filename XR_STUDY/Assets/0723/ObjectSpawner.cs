using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn() {
        while (true) {
            var obj = ObjectPoolingManager.Instance.Get("ball");
            obj.transform.position = Random.insideUnitSphere * 5f;
            yield return new WaitForSeconds(0.5f);
        }
    }

    
}
