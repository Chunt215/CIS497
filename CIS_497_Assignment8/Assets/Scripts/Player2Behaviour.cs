/*
 * Camron Hunt
 * Player2Behaviour
 * Assignment 8 
 * Controls the specific behaviors of player 2
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Behaviour : PlayersBehaviour
{
    public GameObject projectile;
    public GameObject shield;

    public override void Cast()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            HideMenu();
        }
    }

    public override void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.gameObject.GetComponent<Animator>().SetBool("isAttacking", true);
            Invoke("ReturnToIdle", 1f);
            HideMenu();
        }
    }

    public override void Defend()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Instantiate(shield, transform.position, Quaternion.identity);
            HideMenu();
        }
    }
}
