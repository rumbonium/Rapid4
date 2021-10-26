using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderBehavior : MonoBehaviour
{
    public Color GOODCOLOR;
    public Color SMALLCOLOR;
    public Color LARGECOLOR;


    public Slider slider;
    public Image fill;
    public int SMALLBOARDER;
    public int LARGEBORDER;
    public float updateSeconds;
    private float timeSince = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSince += Time.deltaTime;
        if(timeSince > updateSeconds){
            slider.value -= 5f;
            timeSince = 0f;
        }

        if(slider.value < SMALLBOARDER){
            fill.color = SMALLCOLOR;
        }
        else if(slider.value > LARGEBORDER){
            fill.color = LARGECOLOR;
        }
        else{
            fill.color = GOODCOLOR;
        }

    }
}
