using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconBehavior : MonoBehaviour
{
    public GameObject factorObject;
    public Slider factorSlider;
    public float highlightPercentage;
    private PlantFactorBehavior factor;
    private Image image;
    private float midValue;
    private float sliderRange;
    void Start()
    {
        factor = factorObject.GetComponent<PlantFactorBehavior>();
        image = GetComponent<Image>();
        midValue = (factor.HighCrossValue + factor.LowCrossValue) / 2f;
        sliderRange = factorSlider.maxValue - factorSlider.minValue;
    }

    // Update is called once per frame
    void Update()
    {
        if(factorSlider.value > midValue - highlightPercentage*sliderRange && factorSlider.value < midValue + highlightPercentage*sliderRange){
            var tempColor = image.color;
            tempColor.a = 1f;
            image.color = tempColor;
        }
        else{
            var tempColor = image.color;
            tempColor.a = 0.5f;
            image.color = tempColor;
        }
    }
}
