  
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderValue : MonoBehaviour
{
    public Slider MySlider;
 
    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("TimerValue", MySlider.value);
    }
}

