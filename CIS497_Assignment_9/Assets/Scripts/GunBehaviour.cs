/* 
 * Camron Hunt
 * GunBehaviour.cs 
 * Assignment 9
 * controls the gun state
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehaviour : MonoBehaviour, WeaponState
{
    public GameObject bullet;
    public float projSpeed = 100f;
    public float speed = 5f;

    void Update()
    {
        Movement();
    }

    public void Attack()
    {
        var proj = Instantiate(bullet, transform.position, Quaternion.identity);
        proj.GetComponent<Rigidbody2D>().AddForce(transform.right * projSpeed);
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
