/* 
 * Camron Hunt
 * ColourBehaviour.cs 
 * Assignment 7
 * changes the color of the light object
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourBehaviour : MonoBehaviour
{
    public SpriteRenderer sr;
    public string curColor;

    // Start is called before the first frame update
    void Start()
    {
        sr = this.gameObject.GetComponent<SpriteRenderer>();
        curColor = "White";
    }

    public void ChangeToBlue()
    {
        sr.color = Color.blue;
        curColor = "Blue";
    }

    public void ChangeToRed()
    {
        sr.color = Color.red;
        curColor = "Red";
    }

    public void ChangeToYellow()
    {
        sr.color = Color.yellow;
        curColor = "Yellow";
    }
}