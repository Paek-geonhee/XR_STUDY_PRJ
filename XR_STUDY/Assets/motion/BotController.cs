using UnityEngine;

public class BotController : MonoBehaviour
{
    public Transform TR_cup;
    private Animator AN;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AN = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AN.SetFloat("verticalSpeed", Input.GetAxis("Vertical"));
        AN.SetFloat("horizontalSpeed", Input.GetAxis("Horizontal"));
    }

    private void OnAnimatorIK(int layerIndex)
    {
        AN.SetIKPosition(AvatarIKGoal.RightHand, TR_cup.transform.position);
        // 오른쪽 손이 컵의 위치에 맞게 이동하도록 설정해라.
        AN.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
        // 0 ~ 1(전부) 값.
        AN.SetIKRotation(AvatarIKGoal.RightHand, TR_cup.transform.rotation);
        AN.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
    }
}
