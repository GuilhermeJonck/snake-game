using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class SliderDificuldade : MonoBehaviour
{
    public Slider slider;
    public static float DificuldadeAtual = (float)0.1;

    void Start()
    {
        slider.onValueChanged.AddListener(OnSliderValueChanged);
        DificuldadeAtual = (float)0.55 - slider.value*(float)0.1;
    }

    void OnSliderValueChanged(float value)
    {
        DificuldadeAtual = (float)0.55 - value*(float)0.1;
        Debug.Log("Dificuldade" + DificuldadeAtual);
    }
}
