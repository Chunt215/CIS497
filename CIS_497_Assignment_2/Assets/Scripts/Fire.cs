/* 
 * Camron Hunt
 * Fire.cs
 * Assignment 2
 * Implements Spells and prints what the functions do
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : Spells
{
    public override void chooseSpell()
    {
        Debug.Log("Fire Active");
    }

    public override string useSpell()
    {
        return "Cast Fire";
    }
}
