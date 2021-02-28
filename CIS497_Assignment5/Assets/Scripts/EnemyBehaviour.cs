/*
 * Camron Hunt 
 * EnemyBehaviour.cs
 * Assignment 5
 * makes the enemy a type and change their type to match 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public int health = 10;
    public string enemyType;

    // Start is called before the first frame update
    void Start()
    {
        int randType = Random.Range(0, 2);

        switch(randType)
        {
            case 0:
                enemyType = "Fire";
                this.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                break;
            case 1:
                enemyType = "Ice";
                this.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
                break;
            case 2:
                enemyType = "Lightning";
                this.gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}