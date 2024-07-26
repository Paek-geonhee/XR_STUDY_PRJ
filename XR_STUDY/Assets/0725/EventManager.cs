using System;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    // 디커플링 - 객체 간 상호작용 정도를 최소화시킴으로써 느슨한 결합을 구현함.
    // 원리 : 함수 실행의 주체는 이벤트 발생이 어디서 발생했는지 알지 못하고 관심도 없음.
    // 이벤트가 발생했으니 할 일을 할 뿐

    private static EventManager instance;
    public static EventManager Instance {
        get {
            if (instance == null) { 
                // 싱글톤 호출 시 객체가 없는 경우 찾아서 지정
                instance = FindAnyObjectByType<EventManager>();
            }

            if (instance == null) {
                // 씬 내부에 어떤 싱글톤 객체도 없는 경우 직접 생성하여 지정
                var ins = new GameObject(nameof(EventManager));
                instance = ins.AddComponent<EventManager>();
            }

            return instance;
        }
    }

    private Dictionary<string, Action<object>> eventDB;
    // 구독 상태인 이벤트를 담는 유사 데이터베이스

    private void Awake()
    {
        // 기초적인 초기화 과정임.
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else { 
            Destroy(gameObject);    
        }
    }

    public void Subscribe(string eventName, Action<object> action) {
        // eventName이 실행되면 Action을 수행해줘라는 뜻
        eventDB ??= new Dictionary<string, Action<object>>();

        if (!eventDB.ContainsKey(eventName))
        {
            // 이벤트가 없는 경우 DB에 추가
            eventDB.Add(eventName, action);
        }
        else { 
            // 이벤트가 있는 경우 해당 이벤트에 액션을 추가
            eventDB[eventName] += action;
        }
    }

    public void RaiseEvent(string eventName, object obj)
    {
        eventDB ??= new Dictionary<string, Action<object>>();
        if (!eventDB.ContainsKey(eventName))
        {
            throw new Exception(eventName + " 구독자 없음");
        }
        else {
            eventDB[eventName]?.Invoke(obj);
            // ?는 객체가 존재하는 경우 해당 함수를 실행한다는 뜻.
            // 이벤트 데이터베이스에 특정 이벤트가 존재하는 경우 obj를 던져준 뒤 실행 시킴.
        }
    }
}
