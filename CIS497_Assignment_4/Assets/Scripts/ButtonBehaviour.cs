/* 
 * Camron Hunt
 * DebuffDefense
 * Assignment 4
 * Mkaes the game work by clicking buttons
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public Text damageText;
    public Text playerHealth;
    private EnemyBehaviour foe;
    private PlayerBehaviour character;
    private AttackAndDefend buffed;
    private AttackAndDefend debuffed;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth.text = "Health: 100";
        foe = enemy.GetComponent<EnemyBehaviour>();
        character = player.GetComponent<PlayerBehaviour>();
        buffed = character;
        debuffed = foe;
    }

    public void OnClickEnter()
    {
        switch (gameObject.tag)
        {
            case "BuffA":
                buffed = new BuffAttack(buffed);
                damageText.text = "Took " + (debuffed.GetDamage() - buffed.GetDefense()) + " damage";
                break;
            case "BuffD":
                buffed = new BuffDefense(buffed);
                damageText.text = "Took " + (debuffed.GetDamage() - buffed.GetDefense()) + " damage";
                break;
            case "DebuffA":
                debuffed = new DebuffAttack(debuffed);
                damageText.text = "Took " + (debuffed.GetDamage() - buffed.GetDefense()) + " damage";
                break;
            case "DebuffD":
                debuffed = new DebuffDefense(debuffed);
                damageText.text = "Took " + (debuffed.GetDamage() - buffed.GetDefense()) + " damage";
                break;
            default:
                foe.health -= (buffed.GetDamage() + debuffed.GetDefense());
                character.anim.SetBool("isAttacking", true);
                damageText.text = "Took " + (debuffed.GetDamage() - buffed.GetDefense()) + " damage\n" +
                    "Dealt " + (buffed.GetDamage() + debuffed.GetDefense()) + " damage";
                break;
        }
        character.health -= (debuffed.GetDamage() - buffed.GetDefense());
        playerHealth.text = "Health: " + character.health;
        foe.anim.SetBool("isAttacking", true);
        Invoke("ResetAnim", 0.5f);
        Debug.Log("Char stats " + character.health + " " + buffed.GetDefense() + " " + buffed.GetDamage() + "\nEnemy stats " + foe.health + " " +
              debuffed.GetDamage() + " " + debuffed.GetDefense());
    }

    public void ResetAnim()
    {
        if(character.anim != null)
        {
            character.anim.SetBool("isAttacking", false);
        }

        if(foe.anim != null)
        {
            foe.anim.SetBool("isAttacking", false);
        }
    }
}