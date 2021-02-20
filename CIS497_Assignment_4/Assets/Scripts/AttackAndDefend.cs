using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackAndDefend : MonoBehaviour
{
    public abstract int GetDamage();

    public abstract int GetDefense();
}