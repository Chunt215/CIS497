/* 
 * Camron Hunt
 * LightBehaviour.cs
 * Assignment 11
 * The client class for the facade pattern that controls the game
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightBehaviour : MonoBehaviour
{
    public GameObject light1Obj;
    public GameObject light2Obj;
    public GameObject light3Obj;
    public GameObject light4Obj;
    public GameObject light5Obj;
    public GameObject tutorial;
    public GameObject winText;

    private Light1 light1;
    private Light2 light2;
    private Light3 light3;
    private Light4 light4;
    private Light5 light5;

    LightFacade lightFacade;

    // Start is called before the first frame update
    void Start()
    {
        light1 = light1Obj.GetComponent<Light1>();
        light2 = light2Obj.GetComponent<Light2>();
        light3 = light3Obj.GetComponent<Light3>();
        light4 = light4Obj.GetComponent<Light4>();
        light5 = light5Obj.GetComponent<Light5>();

        lightFacade = new LightFacade(light1, light2, light3, light4, light5);

        winText.SetActive(false);

        GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            lightFacade.Light1Click();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            lightFacade.Light2Click();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            lightFacade.Light3Click();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            lightFacade.Light4Click();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            lightFacade.Light5Click();
        }

        if(lightFacade.IsOn())
        {
            EndGame();
        }
    }

    void GameStart()
    {
        int randOn = Random.Range(0, 2);

        if(randOn == 0)
        {
            light1.On();
        }
        else
        {
            light1.Off();
        }

        randOn = Random.Range(0, 2);

        if (randOn == 0)
        {
            light2.On();
        }
        else
        {
            light2.Off();
        }

        randOn = Random.Range(0, 2);

        if (randOn == 0)
        {
            light3.On();
        }
        else
        {
            light3.Off();
        }

        randOn = Random.Range(0, 2);

        if (randOn == 0)
        {
            light4.On();
        }
        else
        {
            light4.Off();
        }

        randOn = Random.Range(0, 2);

        if (randOn == 0)
        {
            light5.On();
        }
        else
        {
            light5.Off();
        }
    }

    void EndGame()
    {
        tutorial.SetActive(false);
        winText.SetActive(true);
        Invoke("Reset", 1.5f);
    }

    void Reset()
    {
        SceneManager.LoadScene(0);
    }
}
