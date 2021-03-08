using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GunBehaviour : MonoBehaviour
{
    public abstract string GetType();
    public abstract void Shoot(string ammoType, Vector3 projPos);
}