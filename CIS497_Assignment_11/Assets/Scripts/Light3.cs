/* 
 * Camron Hunt
 * Light3.cs
 * Assignment 11
 * the class for the third light that controls wheter it's on or off
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light3 : MonoBehaviour
{
    public bool isOn;

    public void On()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        isOn = true;
    }

    public void Off()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        isOn = false;
    }
}
