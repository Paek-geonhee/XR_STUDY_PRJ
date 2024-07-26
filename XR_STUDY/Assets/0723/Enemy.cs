using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public enum EnemyState { 
        Idle,
        Chase,
        Attack,
        Dead
    }

    NavMeshAgent AG;

    [SerializeField]
    private EnemyState State;

    public Transform player;
    public Vector3 debug;
    void Start()
    {
        AG = GetComponent<NavMeshAgent>();
        State = EnemyState.Idle;

        StartCoroutine(Fsm());
    }

    // Update is called once per frame
    void Update()
    {
        //AG.SetDestination(player.position);
        print(Vector3.Distance(debug, transform.position));
        print(State);
    }

    IEnumerator Fsm()
    {
        while (true)
        {
            if (State == EnemyState.Idle)
            {
                var randPos = transform.position + Random.insideUnitSphere.normalized * 2;
                randPos = new Vector3(randPos.x, transform.position.y, randPos.z);
                debug = randPos;
                AG.SetDestination(randPos);
                if (Vector3.Distance(player.position, transform.position) <= 3f)
                {
                    State = EnemyState.Chase;
                }

                yield return new WaitUntil(() => Vector3.Distance(transform.position, randPos) < 0.5f || State == EnemyState.Chase);
            }

            else if (State == EnemyState.Chase)
            {
                AG.SetDestination(player.position);

                if (Vector3.Distance(player.position, transform.position) <= 1f)
                {
                    State = EnemyState.Attack;
                }

                else if (Vector3.Distance(player.position, transform.position) > 1f && Vector3.Distance(player.position, transform.position) <= 3f)
                {
                    State = EnemyState.Chase;
                }

                else if (Vector3.Distance(player.position, transform.position) > 3f)
                {
                    State = EnemyState.Idle;
                }

                yield return null;
            }
            else if (State == EnemyState.Attack) {


                if (Vector3.Distance(player.position, transform.position) > 1f && Vector3.Distance(player.position, transform.position) <= 3f)
                {
                    State = EnemyState.Chase;
                }
                else if (Vector3.Distance(player.position, transform.position) > 3f)
                {
                    State = EnemyState.Idle;
                }

                player.GetComponent<Player>().Hp--;

                yield return new WaitForSeconds(1f);
            }
        }
    }
}
