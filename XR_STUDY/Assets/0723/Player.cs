using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    NavMeshAgent AG;

    public Camera mainCam;
    public int Hp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AG = GetComponent<NavMeshAgent>();
        Hp = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) {
            var ray = mainCam.ScreenPointToRay(Input.mousePosition);
            //print(ray.direction);
            Physics.Raycast(ray, out var hitInfo);



            // out var hitInfo�� ���� var hitInfo�� ���� ����Ǵ� ��� �������� ���ָ� ��� ���� �Լ����� ����� �� �ִ�
            // ���°� ��. ��, �޸𸮰� ��������.

            // ���� �� �ڵ带 �����Ű��, ray�� ���� � ��ü�� hitInfo�� �����.

            //print(hitInfo.point);
            AG.SetDestination(hitInfo.point);
        }
       
    }
}
