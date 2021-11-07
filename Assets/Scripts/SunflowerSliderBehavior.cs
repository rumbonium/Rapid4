using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.Rendering.Universal;

public class SunflowerSliderBehavior : MonoBehaviour
{
    public Slider slider;
    public GameObject plant;
    Animator animator;
    public Light2D light2D;
    public GameObject plantFactor;
    Slider factorSlider;
    PlantFactorBehavior factorBehavior;
    public float FactorIncreaseValue;
    public float SmoothingPercentage;
 

    // Start is called before the first frame update
    void Start()
    {
        animator = plant.GetComponent<Animator>();
        factorSlider = (Slider)plantFactor.transform.GetChild(0).gameObject.GetComponent<Slider>();
        factorBehavior = plantFactor.GetComponent<PlantFactorBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.speed = slider.value * 2f + 0.3f;
        light2D.intensity = slider.value;

        if(Math.Abs(slider.value - factorSlider.value) / slider.value <= SmoothingPercentage){
            factorBehavior.AutoIncreaseValue = 0f;
        }
        else{
            if(factorSlider.value > slider.value){
                factorBehavior.AutoIncreaseValue = -FactorIncreaseValue;
            }
            else{
                factorBehavior.AutoIncreaseValue = FactorIncreaseValue;
            }
        }
    }
}
