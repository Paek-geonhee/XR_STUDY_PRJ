using UnityEngine;
using UnityEngine.SceneManagement;

public class TranslateScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("LoadScene",3f);
        
    }

    void LoadScene() {
        SceneManager.LoadScene("0718",LoadSceneMode.Additive);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
