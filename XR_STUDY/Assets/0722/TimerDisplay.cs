using System;
using TMPro;
using UnityEngine;

public class TimerDisplay : MonoBehaviour
{
    public TMP_Text label;
    public TMP_Text timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        label.gameObject.SetActive(GameManager.instance.isGameStart);
        timer.gameObject.SetActive(GameManager.instance.isGameStart);

        var gameTime = GameManager.instance.gameTime;
        var gameTimeSpan = new TimeSpan(0,0,0,0,(int)(gameTime * 1000));
        print(gameTimeSpan.ToString());

        timer.SetText(gameTimeSpan.Minutes.ToString() + " : "  + gameTimeSpan.Seconds.ToString() + " : " + gameTimeSpan.Milliseconds.ToString());
    }
}
