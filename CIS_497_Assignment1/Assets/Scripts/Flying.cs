/* 
 * Camron Hunt
 * Flying.cs
 * Assignment 1
 * A class of flying enemies that move towards a target and around high obstacles
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : Enemy
{
    private Vector3 target;

    public override void move()
    {
        Debug.Log("Move towards a target");
    }

    public override void shoot()
    {
        Debug.Log("Shoot a projectile at target");
    }

    public override bool pathClear()
    {
        Debug.Log("Path is clear");
        return true;
    }
}