/* 
 * Camron Hunt
 * Light4.cs
 * Assignment 11
 * the class for the fourth light that controls wheter it's on or off
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light4 : MonoBehaviour
{
    public bool isOn;

    public void On()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        isOn = true;
    }

    public void Off()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        isOn = false;
    }
}
