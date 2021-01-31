using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulator : MonoBehaviour
{
    private List<Enemy> enemies;
    private List<IAttack> foes;

    // Start is called before the first frame update
    void Start()
    {
        enemies = new List<Enemy>();
        foes = new List<IAttack>();
        Flying enemy1 = new Flying();
        Flying enemy2 = new Flying();
        Grounded enemy3 = new Grounded();
        Grounded enemy4 = new Grounded();
        Underground enemy5 = new Underground();
        enemies.Add(enemy1);
        enemies.Add(enemy2);
        enemies.Add(enemy3);
        enemies.Add(enemy4);
        enemies.Add(enemy5);
        foes.Add(enemy1);
        foes.Add(enemy2);
        foes.Add(enemy3);
        foes.Add(enemy4);
        foes.Add(enemy5);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.move();
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (IAttack foe in foes)
            {
                foe.shoot();
            }
        }
    }
}