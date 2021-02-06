/* 
 * Camron Hunt
 * Spells.cs
 * Assignment 2
 * Creates an abstract class with functions for choosing spells and using them 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spells : MonoBehaviour
{
    public abstract void chooseSpell();
    public abstract void useSpell();
}
