/*
 * Camron Hunt
 * GameController.cs
 * Assignment 3
 * implements the subject interface and spawns items in the scene
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour, ISubject
{
    public GameObject alarm;
    public GameObject enemy;
    public GameObject alertZone;
    public List<IObserver> observers = new List<IObserver>();

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            Vector2 alertPos = new Vector2();
            alertPos.x = -6 + (i * 3);
            alertPos.y = Random.Range(-3f, 3f);
            Instantiate(alertZone, alertPos, Quaternion.identity);
        }

        Vector2 alarmPos = new Vector2(8.9f, 5f);
        for (int i = 0; i < 4; i++)
        {
            if(i % 2 == 0)
            {
                alarmPos.x *= -1;
            }
            else
            {
                alarmPos.y *= -1;
            }
            var alarmPF = Instantiate(alarm, alarmPos, Quaternion.identity);
            AddObserver(alarmPF.GetComponent<AlarmBehaviour>());
        }

        Vector2 enemyPos = new Vector2(-7f, 3f);
        var enemy1 = Instantiate(enemy, enemyPos, Quaternion.Euler(0, 0, -90));
        AddObserver(enemy1.GetComponent<EnemyBehaviour>());
        enemyPos.x *= -1;
        enemyPos.y *= -1;
        var enemy2 = Instantiate(enemy, enemyPos, Quaternion.Euler(0, 0, 90));
        AddObserver(enemy2.GetComponent<EnemyBehaviour>());
    }

    public void Notify()
    {
        for(int i = 0; i < observers.Count; i++)
        {
            observers[i].UpdateData();
        }
    }

    //Add observer to the list
    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    //Remove observer from the list
    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }
}
