/*
 * Camron Hunt
 * ISubject.cs
 * Assignment 3
 * creates the subject interface
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubject
{
    public void Notify();

    //Add observer to the list
    public void AddObserver(IObserver observer);

    //Remove observer from the list
    public void RemoveObserver(IObserver observer);
}