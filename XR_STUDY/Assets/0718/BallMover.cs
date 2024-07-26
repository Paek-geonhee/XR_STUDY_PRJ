using UnityEngine;

public class BallMover : MonoBehaviour
{
    public Rigidbody RB;

    void Start()
    {
        
    }

    void Update()
    {
        //RB.linearVelocity = new Vector3(1f, 0, 0);
        RB.AddForce(new Vector3(1f, 0, 0));
    }
}
