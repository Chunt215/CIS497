/*
 * Camron Hunt 
 * SGPiercingRounds.cs
 * Assignment 6
 * controls how the shotgun piercing rounds move and destroy
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SGPiercingRounds : BulletSpawn
{
    public float lifespan = 0.75f;
    public float speed = 3.5f;

    void Start()
    {
        Destroy(this.gameObject, lifespan);
    }

    void FixedUpdate()
    {
        Move();
    }

    public override void Move()
    {
        Rigidbody2D rb2d = gameObject.GetComponent<Rigidbody2D>();
        rb2d.AddRelativeForce(Vector2.up, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<CircleCollider2D>().isTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
    }
}
