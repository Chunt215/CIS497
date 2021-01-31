using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : IAttack, IPathing
{
    public abstract void move();
    public abstract void shoot();
    public abstract bool pathClear();
}