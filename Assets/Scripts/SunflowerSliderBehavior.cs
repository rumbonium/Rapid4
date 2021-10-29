using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.Rendering.Universal;

public class SunflowerSliderBehavior : MonoBehaviour
{
    public Slider slider;
    public GameObject sunflower;
    Animator animator;
    public Light2D light2D;


    // Start is called before the first frame update
    void Start()
    {
        animator = sunflower.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.speed = slider.value * 2f + 0.3f;
        light2D.intensity = slider.value;
    }
}
