using Unity.VisualScripting;
using UnityEngine;

public class CodsStudy : MonoBehaviour
{
    // ���� �����ϱ�
    // 1. Ÿ�� ��� + ������ ���
    int number;
    // 2. ������ ���� ���� ���
    private int secret;
    public int iShared;
    // public ���� �� �����Ϳ��� �� ���� ����
    public float fShared;

    public string text;

    public bool flag;
    // ������ �ڷ����� �������̶�� ���



    public Vector3 direction;

    public string[] fruits;
    // ���� (Global) ���� -> �Լ� �ܺο� �ۼ��� ����
    // ���� (Local) ���� -> �Լ� ���ο� �ۼ��� ����
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
        //    print("10���� ŭ");
        //}
        //else if (number > 20)
        //{
        //    print("20���� ŭ");
        //}
        //else {
        //    print("10���� ����");
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
        // text2�� �ش��ϴ� ���ڿ��� ���.

        string text2 = "Bye World";
        //print("Hello World");
        print(text2);
    }
    void PrintText(string str)
    {
        // str�� �ش��ϴ� ���ڿ��� ���.

        print(str);
    }
}
