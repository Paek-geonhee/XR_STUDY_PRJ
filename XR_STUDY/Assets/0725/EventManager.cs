using System;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    // ��Ŀ�ø� - ��ü �� ��ȣ�ۿ� ������ �ּ�ȭ��Ŵ���ν� ������ ������ ������.
    // ���� : �Լ� ������ ��ü�� �̺�Ʈ �߻��� ��� �߻��ߴ��� ���� ���ϰ� ���ɵ� ����.
    // �̺�Ʈ�� �߻������� �� ���� �� ��

    private static EventManager instance;
    public static EventManager Instance {
        get {
            if (instance == null) { 
                // �̱��� ȣ�� �� ��ü�� ���� ��� ã�Ƽ� ����
                instance = FindAnyObjectByType<EventManager>();
            }

            if (instance == null) {
                // �� ���ο� � �̱��� ��ü�� ���� ��� ���� �����Ͽ� ����
                var ins = new GameObject(nameof(EventManager));
                instance = ins.AddComponent<EventManager>();
            }

            return instance;
        }
    }

    private Dictionary<string, Action<object>> eventDB;
    // ���� ������ �̺�Ʈ�� ��� ���� �����ͺ��̽�

    private void Awake()
    {
        // �������� �ʱ�ȭ ������.
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
        // eventName�� ����Ǹ� Action�� ���������� ��
        eventDB ??= new Dictionary<string, Action<object>>();

        if (!eventDB.ContainsKey(eventName))
        {
            // �̺�Ʈ�� ���� ��� DB�� �߰�
            eventDB.Add(eventName, action);
        }
        else { 
            // �̺�Ʈ�� �ִ� ��� �ش� �̺�Ʈ�� �׼��� �߰�
            eventDB[eventName] += action;
        }
    }

    public void RaiseEvent(string eventName, object obj)
    {
        eventDB ??= new Dictionary<string, Action<object>>();
        if (!eventDB.ContainsKey(eventName))
        {
            throw new Exception(eventName + " ������ ����");
        }
        else {
            eventDB[eventName]?.Invoke(obj);
            // ?�� ��ü�� �����ϴ� ��� �ش� �Լ��� �����Ѵٴ� ��.
            // �̺�Ʈ �����ͺ��̽��� Ư�� �̺�Ʈ�� �����ϴ� ��� obj�� ������ �� ���� ��Ŵ.
        }
    }
}
