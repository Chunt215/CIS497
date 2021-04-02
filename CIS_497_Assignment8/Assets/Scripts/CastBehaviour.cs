/*
 * Camron Hunt
 * CastBehaviour
 * Assignment 8 
 * Controls the way the casted spells behave
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastBehaviour : MonoBehaviour
{
    public float projSpeed = 5;
    public GameObject target;

    void Start()
    {
        target = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, projSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
