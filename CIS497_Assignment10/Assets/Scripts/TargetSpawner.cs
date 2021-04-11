/*
 * Camron Hunt
 * TargetSpawner.cs
 * Assignment 10
 * controls the spawning of the targets at random locations
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    TargetPooler targetPooler;
    private int randTarget;
    private Vector2 randPos;

    // Start is called before the first frame update
    void Start()
    {
        targetPooler = TargetPooler.instance;
        InvokeRepeating("Spawn", 5f, 3f);
    }

    // Update is called once per frame
    void Spawn()
    {
        randTarget = Random.Range(0, 2);
        randPos.x = Random.Range(-8, 8);
        randPos.y = Random.Range(-4, 3.5f);

        if (randTarget == 1)
        {
            targetPooler.SpawnFromPool("Target", randPos, Quaternion.identity);
        }
        else
        {
            targetPooler.SpawnFromPool("HighValue", randPos, Quaternion.identity);
        }
    }
}
