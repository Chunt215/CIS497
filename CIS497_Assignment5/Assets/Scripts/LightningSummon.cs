/*
 * Camron Hunt 
 * LightningSummon.cs
 * Assignment 5
 * implements the abstract class Summon behaviour and controls an Lightning type summon 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningSummon : SummonBehaviour
{
    public float speed = 3.0f;
    public int damage;
    public GameObject enemy;
    public GameObject player;
    private PlayerBehaviour pBehaviour;
    private EnemyBehaviour eBehaviour;

    void Start()
    {
        enemy = GameObject.Find("Enemy(Clone)");
        player = GameObject.Find("Player");
        eBehaviour = enemy.GetComponent<EnemyBehaviour>();
        pBehaviour = player.GetComponent<PlayerBehaviour>();
    }

    void Update()
    {
        Move();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Damage();
        Destroy(gameObject);
    }

    public override void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, enemy.transform.position, speed * Time.deltaTime);
    }

    public override void Damage()
    {
        damage = 2;
        switch(eBehaviour.enemyType)
        {
            case "Fire":
                damage *= 2;
                eBehaviour.health -= damage;
                break;
            case "Ice":
                damage /= 2;
                eBehaviour.health -= damage;
                break;
            case "Lightning":
                eBehaviour.health -= damage;
                break;
        }
    }
}