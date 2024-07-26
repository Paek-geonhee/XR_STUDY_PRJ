using UnityEngine;

public class Scriptor : MonoBehaviour
{
    public Vector3 initPosition;
    void Start()
    {
        transform.position = initPosition;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(new Vector3(1.0f,0,0)*Time.deltaTime);
        }

        else if(Input.GetKey(KeyCode.D)){
            transform.Translate(new Vector3(-1.0f,0,0)*Time.deltaTime);
        }
    }
}
