using UnityEngine;
using TMPro;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI passwordDisplay;

    private Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        passwordDisplay.text = slider.value.ToString();
    }

    public void ChangeValue(float value)
    {
        passwordDisplay.text = value.ToString();
    }
}
