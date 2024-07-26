using Unity.VisualScripting;
using UnityEngine;

public class CodsStudy : MonoBehaviour
{
    // 변수 선언하기
    // 1. 타입 명시 + 변수명 명시
    int number;
    // 2. 데이터 은닉 여부 명시
    private int secret;
    public int iShared;
    // public 설정 시 에디터에서 값 설정 가능
    public float fShared;

    public string text;

    public bool flag;
    // 까지의 자료형을 원시형이라고 명명



    public Vector3 direction;

    public string[] fruits;
    // 전역 (Global) 변수 -> 함수 외부에 작성된 변수
    // 지역 (Local) 변수 -> 함수 내부에 작성된 변수
    void Start()
    {
        foreach (var fruit in fruits) {
            print(fruit);
        }

        for (int i = 0; i < fruits.Length; i++) {
            print(fruits[i]);
        }
        //number = iShared;
        //print(Launch(flag));
        //print(text);
        //PrintText2();
        //PrintText("Start");
        
        //if (number > 10 && number <= 20)
        //{
        //    print("10보다 큼");
        //}
        //else if (number > 20)
        //{
        //    print("20보다 큼");
        //}
        //else {
        //    print("10보다 작음");
        //}
    }

   
    void Update()
    {






        //print(Launch(flag));
        //int result = Calculate(2, 4);

        //print(text);//print(text2);
        //PrintText2();
        //PrintText("Update");
        //print(result);
    }

    int Calculate(int a, int b) {
        return a + b;
    }


    string Launch(bool isTrue) {
        string text;
        if (isTrue) {
            text = "Launch";
        }
        else { 
            text = "Not Launch";
        }
        return text;
    }










    // =================================================================

    void PrintText2() {
        // text2에 해당하는 문자열을 출력.

        string text2 = "Bye World";
        //print("Hello World");
        print(text2);
    }
    void PrintText(string str)
    {
        // str에 해당하는 문자열을 출력.

        print(str);
    }
}
