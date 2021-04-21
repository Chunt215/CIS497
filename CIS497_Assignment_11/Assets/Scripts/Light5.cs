/* 
 * Camron Hunt
 * Light5.cs
 * Assignment 11
 * the class for the fifth light that controls wheter it's on or off
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light5 : MonoBehaviour
{
    public bool isOn;
    private Color purple = new Color(0.5f, 0, 1f, 1f);

    public void On()
    {
        gameObject.GetComponent<SpriteRenderer>().color = purple;
        isOn = true;
    }

    public void Off()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        isOn = false;
    }
}
