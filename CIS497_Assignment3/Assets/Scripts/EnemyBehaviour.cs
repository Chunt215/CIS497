/*
 * Camron Hunt
 * EnemyBehaviour.cs
 * Assignment 3
 * implements the observer interface and controls enemies' behavior
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour, IObserver
{
    public bool activated = false;
    public float speed = 3f;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(!activated)
        {
            if (transform.position.x <= -7)
            {
                transform.rotation = Quaternion.Euler(0, 0, -90);
            }
            else if (transform.position.x >= 7)
            {
                transform.rotation = Quaternion.Euler(0, 0, 90);
            }
            transform.position += transform.up * speed * Time.deltaTime;
        }
        else
        {
            speed = 7f;
            Vector3 screenPos = player.transform.position;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);

            Vector2 delta = transform.position - worldPos;

            float angle = Mathf.Atan2(delta.y, delta.x) * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(new Vector3(0, 0, angle));

            transform.rotation = rot;

            transform.position = Vector3.MoveTowards(transform.position,
                                                     player.transform.position,
                                                     speed * Time.deltaTime);
        }
    }

    public void UpdateData()
    {
        activated = true;
    }
}
