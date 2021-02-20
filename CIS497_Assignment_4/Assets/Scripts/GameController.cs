using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public GameObject winText;
    public GameObject loseText;
    private EnemyBehaviour eBehaviour;
    private PlayerBehaviour pBehaviour;

    // Start is called before the first frame update
    void Start()
    {
        eBehaviour = enemy.GetComponent<EnemyBehaviour>();
        pBehaviour = player.GetComponent<PlayerBehaviour>();
        winText.SetActive(false);
        loseText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(eBehaviour.health <= 0)
        {
            Destroy(enemy);
            winText.SetActive(true);
            Invoke("Reset", 1f);
        }
        
        if(pBehaviour.health <= 0)
        {
            Destroy(player);
            loseText.SetActive(true);
            Invoke("Reset", 1f);
        }
    }

    void Reset()
    {
        SceneManager.LoadScene(0);
    }
}
