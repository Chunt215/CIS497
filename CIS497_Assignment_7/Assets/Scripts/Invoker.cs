/* 
 * Camron Hunt
 * Invoker.cs 
 * Assignment 7
 * Controls which command will be executed 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour
{
    public GameObject commands;
    public GameObject gcObject;
    private GameController gc;

    void Start()
    {
        gc = gcObject.GetComponent<GameController>();
    }

    public void SetCommand()
    {
        switch(gameObject.tag)
        {
            case "Blue":
                gc.curCommand = commands.GetComponent<BlueCommand>();
                break;
            case "Red":
                gc.curCommand = commands.GetComponent<RedCommand>();
                break;
            case "Yellow":
                gc.curCommand = commands.GetComponent<YellowCommand>();
                break;
        }
    }
}
