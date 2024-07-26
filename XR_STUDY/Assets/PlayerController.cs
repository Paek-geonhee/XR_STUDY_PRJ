using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody RB;

    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move(){
        float zaxis = (Input.GetKey(KeyCode.W) ? 1 : 0) - (Input.GetKey(KeyCode.S) ? 1 : 0);
        float xaxis = (Input.GetKey(KeyCode.D) ? 1 : 0) - (Input.GetKey(KeyCode.A) ? 1 : 0);


        
        RB.linearVelocity = new Vector3(xaxis,0,zaxis).normalized*speed + new Vector3(0,RB.linearVelocity.y,0);
    }

    void Jump(){
       // float jumped = Input.GetKeyDown(KeyCode.Space) ? 1 : 0;

        if(Input.GetKeyDown(KeyCode.Space)){
            RB.linearVelocity = new Vector3(RB.linearVelocity.x,speed,RB.linearVelocity.z);
        }
        else{
            RB.linearVelocity = new Vector3(RB.linearVelocity.x,RB.linearVelocity.y,RB.linearVelocity.z);
        }
        
    }
}
