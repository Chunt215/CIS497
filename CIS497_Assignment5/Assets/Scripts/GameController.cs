/*
 * Camron Hunt 
 * GameController.cs
 * Assignment 5
 * spawns new enemies when one is destroyed 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject enemy;
    public GameObject curEnemy;
    public GameObject tutorial;
    public GameObject affinity;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemy, new Vector3(0, 4.0f, 0), Quaternion.identity);
        Destroy(tutorial, 3.0f);
        Destroy(affinity, 3.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        curEnemy = GameObject.FindGameObjectWithTag("Enemy");
        Invoke("EnemyRespawn", 1.5f);
    }

    void EnemyRespawn()
    {
        if (curEnemy == null)
        {
            Instantiate(enemy, new Vector3(0, 4.0f, 0), Quaternion.identity);
        }
    }
}