/* 
 * Camron Hunt
 * BuffAttack
 * Assignment 4
 * Raises the damage that the player does
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffAttack : PotionBehaviour
{
    AttackAndDefend player;

    public BuffAttack(AttackAndDefend player)
    {
        this.player = player;
    }

    public override int GetDamage()
    {
        return player.GetDamage() + 1;
    }

    public override int GetDefense()
    {
        return player.GetDefense();
    }
}
