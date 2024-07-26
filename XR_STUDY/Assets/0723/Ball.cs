using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        transform.position = Random.insideUnitSphere*5f;
        Invoke("Delete", 3f);
    }

    void Delete() { 
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
