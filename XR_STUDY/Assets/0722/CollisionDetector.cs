using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameObject particle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.contacts[0].point);
        Instantiate(particle, collision.contacts[0].point, Quaternion.identity);
    }
}
