using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LabelPrinter : MonoBehaviour
{
    TMP_Text text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = GetComponent<TMP_Text>();

        text.SetText("No Message");
        // Action<object> �� �Լ����� ���� ���� �̺�Ʈ �Ŵ��� ���� Invoke���� ���� ������ ����� ��.
        EventManager.Instance.Subscribe("ButtonClicked", PrintText);
    }

    void PrintText(object obj) { 
        text.SetText((string)obj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
