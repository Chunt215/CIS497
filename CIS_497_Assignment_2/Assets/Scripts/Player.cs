using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Spells activeSpell;
    public GameObject spellSlot1;
    public GameObject spellSlot2;
    public GameObject spellSlot3;

    // Start is called before the first frame update
    void Start()
    {
        activeSpell = gameObject.AddComponent<Fire>();
        spellSlot1.GetComponent<SpriteRenderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            activeSpell.useSpell();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            spellSlot2.GetComponent<SpriteRenderer>().material.color = Color.white;
            spellSlot3.GetComponent<SpriteRenderer>().material.color = Color.white;
            Destroy(GetComponent<Spells>());
            spellSlot1.GetComponent<SpriteRenderer>().material.color = Color.red;
            activeSpell = gameObject.AddComponent<Fire>();
            activeSpell.chooseSpell();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spellSlot1.GetComponent<SpriteRenderer>().material.color = Color.white;
            spellSlot3.GetComponent<SpriteRenderer>().material.color = Color.white;
            Destroy(GetComponent<Spells>());
            spellSlot2.GetComponent<SpriteRenderer>().material.color = Color.blue;
            activeSpell = gameObject.AddComponent<Ice>();
            activeSpell.chooseSpell();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spellSlot2.GetComponent<SpriteRenderer>().material.color = Color.white;
            spellSlot1.GetComponent<SpriteRenderer>().material.color = Color.white;
            Destroy(GetComponent<Spells>());
            spellSlot3.GetComponent<SpriteRenderer>().material.color = Color.yellow;
            activeSpell = gameObject.AddComponent<Lightning>();
            activeSpell.chooseSpell();
        }
    }
}
