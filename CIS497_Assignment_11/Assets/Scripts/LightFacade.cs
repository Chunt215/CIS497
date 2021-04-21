/* 
 * Camron Hunt
 * LightFacade.cs
 * Assignment 11
 * The facade class that controls the lights
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFacade : MonoBehaviour
{
    Light1 light1;
    Light2 light2;
    Light3 light3;
    Light4 light4;
    Light5 light5;

    public LightFacade(Light1 light1, Light2 light2, Light3 light3, Light4 light4, Light5 light5)
    {
        this.light1 = light1;
        this.light2 = light2;
        this.light3 = light3;
        this.light4 = light4;
        this.light5 = light5;
    }

    public void Light1Click()
    {
        if(light1.isOn)
        {
            light1.Off();
        }
        else
        {
            light1.On();
        }
        
        if(light2.isOn)
        {
            light2.Off();
        }
        else
        {
            light2.On();
        }
    }

    public void Light2Click()
    {
        if (light1.isOn)
        {
            light1.Off();
        }
        else
        {
            light1.On();
        }

        if (light2.isOn)
        {
            light2.Off();
        }
        else
        {
            light2.On();
        }

        if (light3.isOn)
        {
            light3.Off();
        }
        else
        {
            light3.On();
        }
    }

    public void Light3Click()
    {
        if (light4.isOn)
        {
            light4.Off();
        }
        else
        {
            light4.On();
        }

        if (light2.isOn)
        {
            light2.Off();
        }
        else
        {
            light2.On();
        }

        if (light3.isOn)
        {
            light3.Off();
        }
        else
        {
            light3.On();
        }
    }

    public void Light4Click()
    {
        if (light4.isOn)
        {
            light4.Off();
        }
        else
        {
            light4.On();
        }

        if (light5.isOn)
        {
            light5.Off();
        }
        else
        {
            light5.On();
        }

        if (light3.isOn)
        {
            light3.Off();
        }
        else
        {
            light3.On();
        }
    }

    public void Light5Click()
    {
        if (light5.isOn)
        {
            light5.Off();
        }
        else
        {
            light5.On();
        }

        if (light4.isOn)
        {
            light4.Off();
        }
        else
        {
            light4.On();
        }
    }

    public bool IsOn()
    {
        bool on = false;
        if(light1.isOn && light2.isOn && light3.isOn && light4.isOn && light5.isOn)
        {
            on = true;
        }
        return on;
    }
}
