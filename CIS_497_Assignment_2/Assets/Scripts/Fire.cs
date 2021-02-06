using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : Spells
{
    public override void chooseSpell()
    {
        Debug.Log("Fire Active");
    }

    public override void useSpell()
    {
        Debug.Log("Cast Fire");
    }
}
