using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    public int score;
    public float gameTime;

    public bool isGameStart;
    public bool isGameEnd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        //else { 
        //    Destroy(this);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameStart) {
            gameTime += Time.deltaTime;
        }

        if (gameTime >= 10f) { 
            isGameStart = false;
            isGameEnd = true;
            gameTime = 0;
        }
    }

    public void Restart() {
        gameTime = 0;
        score = 0;
        isGameStart = false;
        isGameEnd = false;
    }
}
