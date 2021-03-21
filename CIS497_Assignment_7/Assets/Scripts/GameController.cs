/* 
 * Camron Hunt
 * GameController.cs 
 * Assignment 7
 * Controls the win condition and colors of the lights 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject commandObj;
    public GameObject leftSelect;
    public GameObject midSelect;
    public GameObject rightSelect;
    public GameObject left;
    public GameObject mid;
    public GameObject right;
    public Text leftColorText;
    public Text midColorText;
    public Text rightColorText;
    public GameObject winText;
    public Command curCommand;
    private int randLeft;
    private int randMid;
    private int randRight;
    private ColourBehaviour leftColor;
    private ColourBehaviour midColor;
    private ColourBehaviour rightColor;

    void Start()
    {
        curCommand = commandObj.GetComponent<BlueCommand>();
        midSelect.SetActive(false);
        rightSelect.SetActive(false);
        winText.SetActive(false);
        randLeft = Random.Range(1, 4);
        randMid = Random.Range(1, 4);
        randRight = Random.Range(1, 4);
        leftColor = left.GetComponent<ColourBehaviour>();
        midColor = mid.GetComponent<ColourBehaviour>();
        rightColor = right.GetComponent<ColourBehaviour>();

        switch(randLeft)
        {
            case 1:
                leftColorText.text = "Yellow";
                break;
            case 2:
                leftColorText.text = "Red";
                break;
            case 3:
                leftColorText.text = "Blue";
                break;
        }

        switch (randMid)
        {
            case 1:
                midColorText.text = "Yellow";
                break;
            case 2:
                midColorText.text = "Red";
                break;
            case 3:
                midColorText.text = "Blue";
                break;
        }

        switch (randRight)
        {
            case 1:
                rightColorText.text = "Yellow";
                break;
            case 2:
                rightColorText.text = "Red";
                break;
            case 3:
                rightColorText.text = "Blue";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            curCommand.SetLight(GameObject.Find("Left"));
            leftSelect.SetActive(true);
            midSelect.SetActive(false);
            rightSelect.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            curCommand.SetLight(GameObject.Find("Mid"));
            leftSelect.SetActive(false);
            midSelect.SetActive(true);
            rightSelect.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            curCommand.SetLight(GameObject.Find("Right"));
            leftSelect.SetActive(false);
            midSelect.SetActive(false);
            rightSelect.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            curCommand.Execute();
        }

        if(leftColorText.text == leftColor.curColor &&
            midColorText.text == midColor.curColor &&
            rightColorText.text == rightColor.curColor)
        {
            Win();
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
    }

    public void Win()
    {
        winText.SetActive(true);
        Invoke("Restart", 2.0f);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
