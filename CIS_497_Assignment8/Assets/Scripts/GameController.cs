/*
 * Camron Hunt
 * GameController
 * Assignment 8 
 * Controls the basic functions of the game
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject tutorial;

    private PlayersBehaviour p1;
    private PlayersBehaviour p2;
    private PlayersBehaviour p3;
    private PlayersBehaviour curPlayer;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = false;

        p1 = player1.GetComponent<PlayersBehaviour>();
        p2 = player2.GetComponent<PlayersBehaviour>();
        p3 = player3.GetComponent<PlayersBehaviour>();
        curPlayer = p1;
        Invoke("HideTutorial", 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            curPlayer = p1;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            curPlayer = p2;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            curPlayer = p3;
        }

        curPlayer.Action();
    }

    void HideTutorial()
    {
        tutorial.SetActive(false);
    }
}
