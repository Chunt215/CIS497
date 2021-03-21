/* 
 * Camron Hunt
 * Command.cs 
 * Assignment 7
 * interface for the color change commands
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Command
{
    public void Execute();
    public void SetLight(GameObject light);
}
