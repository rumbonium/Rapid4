using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerBehavior : MonoBehaviour
{
    public PlantFactorBehavior plantFactorBehavior;
    public Text text;
    void Start()
    {
        text.text = plantFactorBehavior.state.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = plantFactorBehavior.state.ToString();
    }
}
