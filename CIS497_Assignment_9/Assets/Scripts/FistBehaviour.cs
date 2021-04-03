/* 
 * Camron Hunt
 * FistBehaviour.cs 
 * Assignment 9
 * controls the fist state
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistBehaviour : MonoBehaviour, WeaponState
{
    public float speed = 5f;

    void Update()
    {
        Movement();
    }

    public void Attack()
    {
        gameObject.GetComponent<Animator>().SetBool("isAttacking", true);
        Invoke("Reset", .1f);
    }

    public void Reset()
    {
        gameObject.GetComponent<Animator>().SetBool("isAttacking", false);
    }

    void Movement()
    {
        // yMove and xMove will be set to a value between -1 and 1
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical");

        // Getting our current position
        Vector3 newPos = transform.position;

        // Changing the position
        newPos.x += xMove * Time.deltaTime * speed;
        newPos.y += yMove * Time.deltaTime * speed;

        // Setting our position to the new one
        transform.position = newPos;
    }
}
