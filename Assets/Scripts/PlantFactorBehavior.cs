using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantFactorBehavior : MonoBehaviour
{
    public enum PlantFactorState {LOW, MID, HIGH};
    public PlantFactorState state {get; set; }
    public Slider slider;
    public Image fill;
    public float StartValue;
    public Color LowColor;
    public Color MidColor;
    public Color HighColor;
    public float LowCrossValue;
    public float HighCrossValue;
    private float MidValue;
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
        state = (StartValue > HighCrossValue) ? PlantFactorState.HIGH 
                : (StartValue < LowCrossValue) ? PlantFactorState.LOW 
                : PlantFactorState.MID;

        IncreaseTimer = 0f;
        DecreaseTimer = 0f;
        MidValue = (HighCrossValue + LowCrossValue) / 2f;
    }

    void Update()
    {
        MidValue = (HighCrossValue + LowCrossValue) / 2f;
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
            state = PlantFactorState.HIGH;
        }
        else if(slider.value < LowCrossValue){
            fill.color = LowColor;
            state = PlantFactorState.LOW;
        }
        else if(slider.value > LowCrossValue && slider.value < MidValue){
            fill.color = Color.Lerp(LowColor, MidColor, (slider.value - LowCrossValue) / (MidValue - LowCrossValue));
            state = PlantFactorState.MID;
        }
        else if(slider.value < HighCrossValue && slider.value > MidValue){
            fill.color = Color.Lerp(MidColor, HighColor, (slider.value - MidValue) / (HighCrossValue - MidValue));
            state = PlantFactorState.MID;
        }
        else{
            fill.color = MidColor;
            state = PlantFactorState.MID;
        }
    }

    public void IncreaseAction(){
        slider.value += ManualIncreaseValue;
    }

    public void DecreaseAction(){
        slider.value -= ManualDecreaseValue;
    }


}
