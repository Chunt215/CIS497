/* 
 * Camron Hunt
 * BlueCommand.cs 
 * Assignment 7
 * changes the color of the selected light to yellow
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCommand : MonoBehaviour, Command
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
        colorChange.ChangeToYellow();
    }

    public void SetLight(GameObject light)
    {
        this.light = light;
    }
}
