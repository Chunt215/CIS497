using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : Spells
{
    public override void chooseSpell()
    {
        Debug.Log("Lightning Active");
    }

    public override void useSpell()
    {
        Debug.Log("Cast Lightning");
    }
}
