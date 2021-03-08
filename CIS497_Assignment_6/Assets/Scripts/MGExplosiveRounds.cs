/*
 * Camron Hunt 
 * MGExplosiveRounds.cs
 * Assignment 6
 * controls how the machine gun explosive rounds move and destroy
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGExplosiveRounds : BulletSpawn
{
    public float lifespan = 1.5f;
    public float speed = 5f;
    public GameObject explosion;

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
        if(collision.gameObject.tag == "Enemy")
        {
            var boom = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(boom, 0.5f);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
