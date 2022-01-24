using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class SliderValueToText : MonoBehaviour
{
    public Slider sliderUI;
    private TextMeshProUGUI textSliderValue;

    void Start()
    {
        textSliderValue = GetComponent<TextMeshProUGUI>();
        ShowSliderValue();
    }

    public void ShowSliderValue()
    {
        string sliderMessage = "Value = " + Mathf.Round(sliderUI.value * 10.0f) * 0.1f; ;
        textSliderValue.text = sliderMessage;   
    }

}