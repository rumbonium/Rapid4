using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantFactorBehavior : MonoBehaviour
{
    public Slider slider;
    public Image fill;
    public float StartValue;
    public Color LowColor;
    public Color MidColor;
    public Color HighColor;
    public float LowCrossValue;
    public float HighCrossValue;
    public float AutoDecreaseTime;
    public float AutoDecreaseValue;
    public float AutoIncreaseTime;
    public float AutoIncreaseValue;
    public float ManualDecreaseValue;
    public float ManualIncreaseValue;

    private float IncreaseTimer;
    private float DecreaseTimer;

    void Start()
    {
        slider.value = StartValue;
        IncreaseTimer = 0f;
        DecreaseTimer = 0f;
    }


/*
Update
    * Increment timers for increase and decrease values
    * If timer expires update value and reset timer
    * Update slider color
*/
    void Update()
    {
        IncreaseTimer += Time.deltaTime;
        DecreaseTimer += Time.deltaTime;

        if(IncreaseTimer > AutoIncreaseTime){
            IncreaseTimer = 0f;
            slider.value += AutoIncreaseValue;
        }

        if(DecreaseTimer > AutoDecreaseTime){
            DecreaseTimer = 0f;
            slider.value -= AutoDecreaseValue;
        }

        if(slider.value > HighCrossValue){
            fill.color = HighColor;
        }
        else if(slider.value < LowCrossValue){
            fill.color = LowColor;
        }
        else{
            fill.color = MidColor;
        }
    }

    void IncreaseAction(){
        slider.value += ManualIncreaseValue;
    }

    void DecreaseAction(){
        slider.value -= ManualDecreaseValue;
    }
}
