/* 
 * Camron Hunt
 * PlayerBehaviour.cs 
 * Assignment 9
 * controls the player and monitors the states
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    List<GameObject> weapons = new List<GameObject>();
    public GameObject fist;
    public GameObject knife;
    public GameObject hammer;
    public GameObject gun;
    public WeaponState curWeapon;
    public float speed = 5f;
    private Vector3 weaponPos;

    // Start is called before the first frame update
    void Start()
    {
        weapons.Add(fist);
        weapons.Add(knife);
        weapons.Add(hammer);
        weapons.Add(gun);
        weaponPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (GameObject.Find("Knife(Clone)") != null)
            {
                Destroy(GameObject.Find("Knife(Clone)"));
            }
            else if (GameObject.Find("Hammer(Clone)") != null)
            {
                Destroy(GameObject.Find("Hammer(Clone)"));
            }
            else if (GameObject.Find("Gun(Clone)") != null)
            {
                Destroy(GameObject.Find("Gun(Clone)"));
            }
            var weapon = Instantiate(weapons[0], weaponPos, Quaternion.identity);
            curWeapon = weapon.GetComponent<FistBehaviour>();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (GameObject.Find("Fist(Clone)") != null)
            {
                Destroy(GameObject.Find("Fist(Clone)"));
            }
            else if (GameObject.Find("Hammer(Clone)") != null)
            {
                Destroy(GameObject.Find("Hammer(Clone)"));
            }
            else if (GameObject.Find("Gun(Clone)") != null)
            {
                Destroy(GameObject.Find("Gun(Clone)"));
            }
            var weapon = Instantiate(weapons[1], weaponPos, Quaternion.identity);
            curWeapon = weapon.GetComponent<KnifeBehaviour>();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (GameObject.Find("Knife(Clone)") != null)
            {
                Destroy(GameObject.Find("Knife(Clone)"));
            }
            else if (GameObject.Find("Fist(Clone)") != null)
            {
                Destroy(GameObject.Find("Fist(Clone)"));
            }
            else if (GameObject.Find("Gun(Clone)") != null)
            {
                Destroy(GameObject.Find("Gun(Clone)"));
            }
            var weapon = Instantiate(weapons[2], weaponPos, Quaternion.identity);
            curWeapon = weapon.GetComponent<HammerBehaviour>();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (GameObject.Find("Knife(Clone)") != null)
            {
                Destroy(GameObject.Find("Knife(Clone)"));
            }
            else if (GameObject.Find("Hammer(Clone)") != null)
            {
                Destroy(GameObject.Find("Hammer(Clone)"));
            }
            else if (GameObject.Find("Fist(Clone)") != null)
            {
                Destroy(GameObject.Find("Fist(Clone)"));
            }
            var weapon = Instantiate(weapons[3], weaponPos, Quaternion.identity);
            curWeapon = weapon.GetComponent<GunBehaviour>();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            curWeapon.Attack();
        }
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

        weaponPos = transform.position;
        weaponPos.x = newPos.x + 1;
    }
}
