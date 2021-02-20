using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : AttackAndDefend
{
    public int health = 10;
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public override int GetDamage()
    {
        return 10;
    }

    public override int GetDefense()
    {
        return 0;
    }
}