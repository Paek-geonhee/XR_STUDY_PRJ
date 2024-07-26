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



            // out var hitInfo는 만약 var hitInfo에 값이 저장되는 경우 지역변수 범주를 벗어나 상위 함수에서 사용할 수 있는
            // 상태가 됨. 즉, 메모리가 남아있음.

            // 따라서 위 코드를 실행시키면, ray에 닿은 어떤 객체가 hitInfo에 저장됨.

            //print(hitInfo.point);
            AG.SetDestination(hitInfo.point);
        }
       
    }
}
