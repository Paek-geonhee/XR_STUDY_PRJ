using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEst : MonoBehaviour
{
    public int HP;
    public int MP;
    public GameObject otherObj;

    BoxCollider BC;
    Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        BC = GetComponent<BoxCollider>();
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }

    void Move(){
       transform.Translate(new Vector3(0.1f,0,0)*Time.deltaTime);
    }

    void OnEnable(){
        print("Hello World");
    }
    void OnDisable(){
        print("Bye World");
    }
    void OnDestroy(){
        print("Boom");
    }
}
