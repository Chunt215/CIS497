/* 
 * Camron Hunt
 * Ice.cs
 * Assignment 2
 * Implements Spells and prints what the functions do
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : Spells
{
    public override void chooseSpell()
    {
        Debug.Log("Ice Active");
    }

    public override void useSpell()
    {
        Debug.Log("Cast Ice");
    }
}
