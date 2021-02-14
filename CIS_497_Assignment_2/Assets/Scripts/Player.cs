/* 
 * Camron Hunt
 * Player.cs
 * Assignment 2
 * This changes what spell is active and the color of spell slots in-game 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Spells activeSpell;
    public GameObject spellSlot1;
    public GameObject spellSlot2;
    public GameObject spellSlot3;
    public Text castText;
    public Color origColor;
    public Color transparent;

    // Start is called before the first frame update
    void Start()
    {
        origColor = castText.color;
        transparent.a = 0.0f;
        castText.color = transparent;
        activeSpell = gameObject.AddComponent<Fire>();
        spellSlot1.GetComponent<SpriteRenderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            castText.text = activeSpell.useSpell();
            castText.color = origColor;
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
