using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffDefense : PotionBehaviour
{
    AttackAndDefend player;

    public BuffDefense(AttackAndDefend player)
    {
        this.player = player;
    }

    public override int GetDamage()
    {
        return player.GetDamage();
    }

    public override int GetDefense()
    {
        return player.GetDefense() + 1;
    }
}