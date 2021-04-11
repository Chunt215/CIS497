/*
 * Camron Hunt
 * TargetBehaviour.cs
 * Assignment 10
 * controls how the targets go back to the object pool
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{
    TargetPooler targetPooler;
    public float lifetime;
    private GameObject gcObject;
    private GameController gc;

    // Start is called before the first frame update
    void Start()
    {
        targetPooler = TargetPooler.instance;
        Invoke("TimeOver", lifetime);
        gcObject = GameObject.Find("GameController");
        gc = gcObject.GetComponent<GameController>();
    }

    void OnMouseDown()
    {
        targetPooler.ReturnObjectToPool(gameObject.tag, gameObject);
        gc.IncreaseScore(gameObject.tag);
    }

    public void TimeOver()
    {
        targetPooler.ReturnObjectToPool(gameObject.tag, gameObject);
    }
}
