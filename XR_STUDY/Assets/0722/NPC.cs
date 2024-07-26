using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public GameObject panel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        panel.SetActive(true);
    }

    public void PanelOff()
    {
        panel.SetActive(false);
    }
}
