using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : Spells
{
    public override void chooseSpell()
    {
        Debug.Log("Ice Active");
    }

    public override void useSpell()
    {
        Debug.Log("Cast Ice");
    }
}
