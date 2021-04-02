/*
 * Camron Hunt
 * PlayersBehaviour
 * Assignment 8 
 * Creates the base for the rest of the playerbehaviour classes
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayersBehaviour : MonoBehaviour
{
    public void Action()
    {
        BringUpMenu();
        Defend();
        Cast();
        Attack();
    }

    public void BringUpMenu()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Find("Canvas").GetComponent<Canvas>().enabled = true;
            Destroy(GameObject.Find("Shield(Clone)"));
        }
    }

    public void HideMenu()
    {
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = false;
    }

    public void ReturnToIdle()
    {
        this.gameObject.GetComponent<Animator>().SetBool("isAttacking", false);
    }

    public abstract void Defend();
    public abstract void Cast();
    public abstract void Attack();
}
