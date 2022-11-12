using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerScript : MonoBehaviour
{

    public float Power = 20;
    public Text AllPower;


    public void AddP1Score()
    {
        Power++;
        AllPower.text = Power.ToString();
    }
}
