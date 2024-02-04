using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slidertest : MonoBehaviour
{
    public void SliderChangeValue()
    {

        float value = this.gameObject.GetComponent<Slider>().value;
        this.gameObject.GetComponent<AudioSource>().volume = value;

        Debug.Log(value*100);
    } 
}
