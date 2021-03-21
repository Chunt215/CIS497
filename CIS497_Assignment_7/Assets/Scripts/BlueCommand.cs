/* 
 * Camron Hunt
 * BlueCommand.cs 
 * Assignment 7
 * changes the color of the selected light to blue
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCommand : MonoBehaviour, Command
{
    public GameObject light;
    public ColourBehaviour colorChange;

    void Start()
    {
        light = GameObject.Find("Left");
    }

    void Update()
    {
        colorChange = light.GetComponent<ColourBehaviour>();
    }

    public void Execute()
    {
        colorChange.ChangeToBlue();
    }

    public void SetLight(GameObject light)
    {
        this.light = light;
    }
}
