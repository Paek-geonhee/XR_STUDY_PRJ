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
        // Action<object> 에 함수명이 들어가면 이후 이벤트 매니저 내부 Invoke문에 의해 적절히 실행될 것.
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
