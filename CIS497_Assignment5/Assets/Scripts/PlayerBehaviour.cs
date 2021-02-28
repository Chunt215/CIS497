/*
 * Camron Hunt 
 * PlayerBehaviour.cs
 * Assignment 5
 * controls the spawning of summons 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public Summoner summoner;
    public string summonType;
    private GameObject summon;
    public GameObject enemy;
    public GameObject summoned;
    public GameObject curEnemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("Enemy(Clone)");
    }

    // Update is called once per frame
    void Update()
    {
        curEnemy = GameObject.FindGameObjectWithTag("Enemy");
        summoned = GameObject.FindGameObjectWithTag("Summoned");
        if(CanSpawn())
        {
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                summonType = "Lightning";
                summon = summoner.Summon(summonType);
                Instantiate(summon, new Vector3(4f, -4.5f, 0), Quaternion.identity);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                summonType = "Ice";
                summon = summoner.Summon(summonType);
                Instantiate(summon, new Vector3(0f, -4.5f, 0), Quaternion.identity);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                summonType = "Fire";
                summon = summoner.Summon(summonType);
                Instantiate(summon, new Vector3(-4f, -4.5f, 0), Quaternion.identity);
            }
        }
    }

    bool CanSpawn()
    {
        if(summoned != null || curEnemy == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}