using UnityEngine; // 네임스페이스
using System;

public class ClassCode : MonoBehaviour {
    [SerializeField]
    private Vector3 position;
    // 얘는 빈 깡통임.
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



        // new를 이용해 실제 객체를 초기화 함.
        //kiwi = new Kiwi();
        //kiwi.sweetness = 100f;
        //print(kiwi.sweetness);


        //print(PowerNumber(kiwi.sweetness));


        kiwi = new Kiwi[10]; // 배열 공간 창출
        kiwi[0] = new Kiwi(); // 실제 객체 생성

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

// sealed 지시자를 이용하면 해당 클래스는 더이상 상속할 수 없다.
public abstract class Fruit {
    public float    sweetness;
    public string   origin;

    [SerializeField]
    private int     age;
    // private을 사용한 경우 자식 클래스가 접근할 수 없음.

    public abstract void Eat();
    public abstract void Dispose();
}

//[Serializable]
// 유니티 컴포넌트 창에서 확인할 수 있도록 만들어주는 지시자 with System.
// 다른 클래스는 보지마! 유니티에서만 볼 거야
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
