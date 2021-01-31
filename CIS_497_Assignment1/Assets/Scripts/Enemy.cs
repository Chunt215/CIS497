/* 
 * Camron Hunt
 * Enemy.cs
 * Assignment 1
 * An abstract class that implements the IAttack and IPathing interfaces
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : IAttack, IPathing
{
    public abstract void move();
    public abstract void shoot();
    public abstract bool pathClear();
}