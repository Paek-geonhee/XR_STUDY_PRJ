using UnityEngine;
using UnityEngine.UI;

public class SliderHandler : MonoBehaviour
{
    public void OnValueChanged(Slider slider) {
        print((int)(slider.value*100));
    }
}
