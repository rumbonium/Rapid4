using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerBehavior : MonoBehaviour
{

    public GameObject waterFactor;
    public GameObject lightFactor;
    public GameObject plantSkeleton;

    private PlantFactorBehavior waterBehavior;
    private PlantFactorBehavior lightBehavior;
    private Animator plantAnimator;

    void Start()
    {
        waterBehavior = waterFactor.GetComponent<PlantFactorBehavior>();
        lightBehavior = lightFactor.GetComponent<PlantFactorBehavior>();
        plantAnimator = plantSkeleton.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(waterBehavior.state != PlantFactorBehavior.PlantFactorState.MID
            || lightBehavior.state != PlantFactorBehavior.PlantFactorState.MID){
            plantAnimator.SetBool("Healthy", false);
        }
        else{
            plantAnimator.SetBool("Healthy", true);
        }
    }
}
