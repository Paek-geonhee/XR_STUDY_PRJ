using UnityEngine;
using System.Collections;

public class CoroutineStudy : MonoBehaviour
{
    [SerializeField]
    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var cr = StartCoroutine(TextPrinter());
        StopCoroutine(cr);
    }


    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;
        //if (timer > 3f) {
        //    print("3�� ���");
        //    timer = 0;
        //}
        
    }

    IEnumerator TextPrinter() {
        //while (true) {
        //    for (int i = 0; i < 10; i++)
        //    {
        //        yield return new WaitForSeconds(3f);
        //        print("3�� ���");
        //    }
        //    print("30�� ���");
        //}

        while (true) {
            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
            // ���ٽ��� �̿��Ͽ� �Լ� ���� / bool
            print("Ŭ��");
        }
        
    }
}
