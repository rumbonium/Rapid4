using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    public GameObject WaterFactor;
    private PlantFactorBehavior waterBehavior;

    // Start is called before the first frame update
    void Start()
    {
        waterBehavior = WaterFactor.GetComponent<PlantFactorBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnParticleCollision(GameObject other)
	{
        Debug.Log("Collision detected: " + other.tag);
        waterBehavior.IncreaseAction();
	}
}
