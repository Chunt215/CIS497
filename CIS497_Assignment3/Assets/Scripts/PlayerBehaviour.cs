/*
 * Camron Hunt
 * PlayerBehaviour.cs
 * Assignment 3
 * this controls how the player moves and interacts with certain objects
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed = 5;
    public bool canMove = true;
    public GameObject gcObject;
    public GameObject tutorial;
    public GameObject goal;
    public GameObject gameOver;
    public GameObject winText;
    private GameController gc;

    // Start is called before the first frame update
    void Start()
    {
        gc = gcObject.GetComponent<GameController>();
        Destroy(tutorial, 5f);
        Destroy(goal, 5f);
        gameOver.SetActive(false);
        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            MovePlayer();
        }

        if(gc.observers.Count <= 2)
        {
            winText.SetActive(true);
            canMove = false;
            Invoke("Reset", 2f);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Alarm")
        {
            Destroy(collider.gameObject);
            gc.RemoveObserver(collider.gameObject.GetComponent<AlarmBehaviour>());
        }
        else if (collider.tag == "Alert")
        {
            gc.Notify();
        }
        else if(collider.tag == "Enemy")
        {
            canMove = false;
            gameOver.SetActive(true);
            Invoke("Reset", 2f);
        }
    }

    void MovePlayer()
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
        newPos.x = Mathf.Clamp(newPos.x, -8.5f, 8.5f);

        // Setting our position to the new one
        transform.position = newPos;
    }

    void Reset()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}