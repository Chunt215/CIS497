using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuffAttack : PotionBehaviour
{
    AttackAndDefend enemy;

    public DebuffAttack(AttackAndDefend enemy)
    {
        this.enemy = enemy;
    }

    public override int GetDamage()
    {
        return enemy.GetDamage() - 1;
    }

    public override int GetDefense()
    {
        return enemy.GetDefense();
    }
}