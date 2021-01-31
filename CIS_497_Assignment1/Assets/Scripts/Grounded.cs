/* 
 * Camron Hunt
 * Grounded.cs
 * Assignment 1
 * A class of grounded enemies that move towards a target along a path and 
 * around all obstacles
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : Enemy
{
    private int speed;

    public override void move()
    {
        Debug.Log("Move along the path");
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