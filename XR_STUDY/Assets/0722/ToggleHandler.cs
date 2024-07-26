using UnityEngine;
using UnityEngine.UI;

public class ToggleHandler : MonoBehaviour
{
    public void OnValueChanged(Toggle tog) { 
        print("Checked? : " + tog.isOn);
    }
}
