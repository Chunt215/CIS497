/*
 * Camron Hunt 
 * Summoner.cs
 * Assignment 5
 * factory that creates summons
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summoner : MonoBehaviour
{
    public GameObject spawnedSummon;
    public GameObject lPrefab;
    public GameObject iPrefab;
    public GameObject fPrefab;

    public GameObject Summon(string type)
    {
        spawnedSummon = null;

        if(type.Equals("Lightning"))
        {
            spawnedSummon = lPrefab;
        }
        else if (type.Equals("Ice"))
        {
            spawnedSummon = iPrefab;
        }
        else if (type.Equals("Fire"))
        {
            spawnedSummon = fPrefab;
        }

        return spawnedSummon;
    }
}