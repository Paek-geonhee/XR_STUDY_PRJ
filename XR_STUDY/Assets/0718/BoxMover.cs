using UnityEngine;

public class BoxMover : MonoBehaviour
{
    //public Transform target;
    //private Rigidbody _RB;
    //private BoxPropertyManager _BPM;
    //public Rigidbody RB;

    public GameObject ballPrefab; // 초기에 NULL
    public int spawnCount;

    private void Start()
    {
        //_RB = GetComponent<Rigidbody>();
        //_BPM = GetComponent<BoxPropertyManager>();
        //_RB.isKinematic = true;
        for (int i = 0; i < spawnCount; i++)
        {
            var madeBall = Instantiate(ballPrefab);

            var randomPosition = Random.insideUnitSphere;
            madeBall.transform.position = randomPosition;

            var rigidbody = madeBall.GetComponent<Rigidbody>();
            rigidbody.AddForce(Vector3.up * 8, ForceMode.Impulse);
        }
        //Instantiate(ballPrefab, Vector3.one, Quaternion.identity);

        //_ball = GameObject.Find("Sphere");
    }
    void Update()
    {
        // 유니티의 전방은 +z축임.
        // 우측은 +x축
        //transform.Rotate(Vector3.up, 30*Time.deltaTime);

        //transform.LookAt(target);

        //target.parent = transform;

        //transform.localScale += Vector3.one * Time.deltaTime;

        //_BPM.boxAge = 10000;
        //_ball.transform.localScale += Vector3.one * Time.deltaTime;
    }
}
