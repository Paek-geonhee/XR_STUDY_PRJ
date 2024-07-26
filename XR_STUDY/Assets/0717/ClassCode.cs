using UnityEngine; // ���ӽ����̽�
using System;

public class ClassCode : MonoBehaviour {
    [SerializeField]
    private Vector3 position;
    // ��� �� ������.
    public Kiwi[] kiwi;

    public Vector3 position2 {
        get {
            return position + new Vector3(3, 2, 1);
        }
    }
    private void Start()
    {
        ///position = new Vector3(1,2,3);
        print("POS1 : " + position);
        // position2 = new Vector3(1,2,3); 
        print("POS2 : " + position2);



        // new�� �̿��� ���� ��ü�� �ʱ�ȭ ��.
        //kiwi = new Kiwi();
        //kiwi.sweetness = 100f;
        //print(kiwi.sweetness);


        //print(PowerNumber(kiwi.sweetness));


        kiwi = new Kiwi[10]; // �迭 ���� â��
        kiwi[0] = new Kiwi(); // ���� ��ü ����

        for (int i = 0; i < kiwi.Length; i++) {
            kiwi[i] = new Kiwi();
            print(i+" : "+kiwi[i]);

        }
    }

    public float PowerNumber(float baseNum) {
        return baseNum * baseNum;
    }

    private void Update()
    {
        
    }
}

// sealed �����ڸ� �̿��ϸ� �ش� Ŭ������ ���̻� ����� �� ����.
public abstract class Fruit {
    public float    sweetness;
    public string   origin;

    [SerializeField]
    private int     age;
    // private�� ����� ��� �ڽ� Ŭ������ ������ �� ����.

    public abstract void Eat();
    public abstract void Dispose();
}

//[Serializable]
// ����Ƽ ������Ʈ â���� Ȯ���� �� �ֵ��� ������ִ� ������ with System.
// �ٸ� Ŭ������ ������! ����Ƽ������ �� �ž�
public class Kiwi : Fruit {
    public override void Eat()
    {
        Debug.Log("SWEET!!");
    }

    public override void Dispose()
    {
        Debug.Log("Dispose!!");
    }
}
