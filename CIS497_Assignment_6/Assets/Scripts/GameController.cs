using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ammoText;
    public GameObject weaponText;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("CloseTutorial", 1.5f);
        InvokeRepeating("SpawnEnemies", 1.0f, 3.0f);
    }

    public void CloseTutorial()
    {
        Destroy(ammoText);
        Destroy(weaponText);
    }

    public void SpawnEnemies()
    {
        Vector3 enemyPos = new Vector3();
        enemyPos.x = Random.Range(-8.4f, 8.4f);
        enemyPos.y = Random.Range(-4.5f, 4.5f);
        Instantiate(enemy, enemyPos, Quaternion.identity);
    }
}
