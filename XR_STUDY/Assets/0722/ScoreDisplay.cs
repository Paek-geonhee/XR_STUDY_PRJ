using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text labelText;


    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isGameStart)
        {
            scoreText.gameObject.SetActive(true);
            labelText.gameObject.SetActive(true);
        }
        else
        {
            scoreText.gameObject.SetActive(false);
            labelText.gameObject.SetActive(false);
        }
    }
}
