/* 
 * Camron Hunt
 * DebuffDefense
 * Assignment 4
 * Raises the damage that the enemy takes
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuffDefense : PotionBehaviour
{
    AttackAndDefend enemy;

    public DebuffDefense(AttackAndDefend enemy)
    {
        this.enemy = enemy;
    }

    public override int GetDamage()
    {
        return enemy.GetDamage();
    }

    public override int GetDefense()
    {
        return enemy.GetDefense() - 1;
    }
}