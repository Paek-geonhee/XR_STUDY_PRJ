using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int score;

    void Start()
    {
        
    }

    void Update()
    {
        text.text = score.ToString();
    }


    public void updateScore() {
        score++;
    }
}
