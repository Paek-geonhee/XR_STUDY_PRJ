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
        //    print("3초 경과");
        //    timer = 0;
        //}
        
    }

    IEnumerator TextPrinter() {
        //while (true) {
        //    for (int i = 0; i < 10; i++)
        //    {
        //        yield return new WaitForSeconds(3f);
        //        print("3초 경과");
        //    }
        //    print("30초 경과");
        //}

        while (true) {
            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
            // 람다식을 이용하여 함수 전달 / bool
            print("클릭");
        }
        
    }
}
