using UnityEngine;

public class EndDisplay : MonoBehaviour
{
    public GameObject panel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        panel.SetActive(GameManager.instance.isGameEnd);
    }

    public void OnClickedRespawn() { 
        GameManager.instance.Restart();
    }
}
