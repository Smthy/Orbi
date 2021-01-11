using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsText : MonoBehaviour
{

    //changes the text next to sliders

    Text sliderNum;
    public Slider speech;


	void Start ()
    {
        sliderNum = GetComponent<Text>();
	}	
	
	public void textUpdate (float value)
    {
        sliderNum.text = Mathf.RoundToInt(value * 100) + "%";
	}
}
