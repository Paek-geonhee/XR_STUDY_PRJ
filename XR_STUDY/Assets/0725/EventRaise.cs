using UnityEngine;

public class EventRaise : MonoBehaviour
{
    public void RaiseEventButtonClicked() {
        EventManager.Instance.RaiseEvent("ButtonClicked", "Hello World");
    }
}
