/*
 * Camron Hunt 
 * SummonBehaviour.cs
 * Assignment 5
 * abstract class for the different summon types
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SummonBehaviour : MonoBehaviour
{
    public abstract void Move();
    public abstract void Damage();
}
