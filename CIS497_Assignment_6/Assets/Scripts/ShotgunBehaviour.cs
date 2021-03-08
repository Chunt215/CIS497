/*
 * Camron Hunt 
 * ShotgunBehaviour.cs
 * Assignment 6
 * creates the shotgun bullets
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunBehaviour : GunBehaviour
{
    public GameObject explosiveRound;
    public GameObject piercingRound;

    public override string GetType()
    {
        return "Shotgun";
    }

    public override void Shoot(string ammoType, Vector3 projPos)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (ammoType == "Explosive")
            {
                var bullet1 = Instantiate(explosiveRound, projPos, Quaternion.Euler(0, 0, -90));
                var bullet2 = Instantiate(explosiveRound, projPos, Quaternion.Euler(0, 0, -77.5f));
                var bullet3 = Instantiate(explosiveRound, projPos, Quaternion.Euler(0, 0, -112.5f));
            }
            else if (ammoType == "Piercing")
            {
                var bullet1 = Instantiate(piercingRound, projPos, Quaternion.Euler(0, 0, -90));
                var bullet2 = Instantiate(piercingRound, projPos, Quaternion.Euler(0, 0, -77.5f));
                var bullet3 = Instantiate(piercingRound, projPos, Quaternion.Euler(0, 0, -112.5f));
            }
        }
    }
}