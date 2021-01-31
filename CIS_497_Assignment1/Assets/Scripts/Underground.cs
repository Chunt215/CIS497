/* 
 * Camron Hunt
 * Underground.cs
 * Assignment 1
 * A class of underground enemies that move towards a target and under or through obstacles
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Underground : Enemy
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
