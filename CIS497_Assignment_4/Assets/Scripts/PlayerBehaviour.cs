using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : AttackAndDefend
{
    public int health = 100;
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public override int GetDamage()
    {
        return 1;
    }

    public override int GetDefense()
    {
        return 0;
    }
}