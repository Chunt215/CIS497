/*
 * Camron Hunt 
 * MachineGunBehaviour.cs
 * Assignment 6
 * creates the machine gun bullets
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunBehaviour : GunBehaviour
{
    public GameObject explosiveRound;
    public GameObject piercingRound;

    public override string GetType()
    {
        return "MachineGun";
    }

    public override void Shoot(string ammoType, Vector3 projPos)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ammoType == "Explosive")
            {
                Instantiate(explosiveRound, projPos, Quaternion.Euler(0, 0, -90));
            }
            else if (ammoType == "Piercing")
            {
                Instantiate(piercingRound, projPos, Quaternion.Euler(0, 0, -90));
            }
        }
    }
}