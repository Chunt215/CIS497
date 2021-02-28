/*
 * Camron Hunt 
 * IceSummon.cs
 * Assignment 5
 * implements the abstract class Summon behaviour and controls an Ice type summon 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSummon : SummonBehaviour
{
    public float speed = 1.0f;
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
        damage = 6;
        switch (eBehaviour.enemyType)
        {
            case "Fire":
                damage /= 2;
                eBehaviour.health -= damage;
                break;
            case "Ice":
                eBehaviour.health -= damage;
                break;
            case "Lightning":
                damage *= 2;
                eBehaviour.health -= damage;
                break;
        }
    }
}