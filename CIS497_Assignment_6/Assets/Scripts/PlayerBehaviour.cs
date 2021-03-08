/*
 * Camron Hunt 
 * PlayerBehaviour.cs
 * Assignment 6
 * controls the players movement and weapons
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public GameObject gunController;
    public GunBehaviour gun;
    public string ammo;
    public float speed = 5.0f;
    public Vector3 projectilePos;
    public float xOffset = .5f;
    public float yOffset = .1f;

    void Start()
    {
        gun = gunController.GetComponent<MachineGunBehaviour>();
        ammo = "Explosive";
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        gun.Shoot(ammo, projectilePos);
        SwitchWeapon();
        SwitchAmmo();
    }

    public void Move()
    {
        // yMove and xMove will be set to a value between -1 and 1
        float yMove = Input.GetAxis("Vertical");
        float xMove = Input.GetAxis("Horizontal");

        // Getting our current position
        Vector3 newPos = transform.position;

        // Changing the position
        newPos.y += yMove * Time.deltaTime * speed;
        newPos.x += xMove * Time.deltaTime * speed;

        newPos.y = Mathf.Clamp(newPos.y, -4.5f, 4.5f);
        newPos.x = Mathf.Clamp(newPos.x, -8.4f, 8.4f);

        // Setting our position to the new one
        transform.position = newPos;

        projectilePos = newPos;
        projectilePos.x += xOffset;
        projectilePos.y += yOffset;
    }

    public void SwitchWeapon()
    {
        if(Input.GetMouseButtonDown(0) && gun.GetType() == "MachineGun")
        {
            gun = gunController.GetComponent<ShotgunBehaviour>();
        }
        else if(Input.GetMouseButtonDown(0) && gun.GetType() == "Shotgun")
        {
            gun = gunController.GetComponent<MachineGunBehaviour>();
        }
    }

    public void SwitchAmmo()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            ammo = "Explosive";
            Debug.Log(ammo);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            ammo = "Piercing";
            Debug.Log(ammo);
        }
    }
}