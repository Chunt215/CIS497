/*
 * Camron Hunt 
 * GunBehaviour.cs
 * Assignment 6
 * creates the gun creator base class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GunBehaviour : MonoBehaviour
{
    public abstract string GetType();
    public abstract void Shoot(string ammoType, Vector3 projPos);
}