/*
 * Camron Hunt
 * AlarmBehaviour.cs
 * Assignment 3
 * implements the observer interface and controls if the alarm goes off
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmBehaviour : MonoBehaviour, IObserver
{
    public bool activated = false;

    // Update is called once per frame
    void Update()
    {
        if(activated)
        {
            GetComponent<Animator>().SetBool("isAlert", true);
        }
    }

    public void UpdateData()
    {
        activated = true;
    }
}
