using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PotionBehaviour : AttackAndDefend
{
    public abstract override int GetDamage();

    public override abstract int GetDefense();
}