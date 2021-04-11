using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int score;
    public int targetsHit;
    public int highValue = 25;
    public int baseValue = 10;
    public Text scoreText;
    public Text targetText;
    public GameObject tutorial;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyTutorial", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        targetText.text = "Targets Hit: " + targetsHit.ToString();
    }

    public void IncreaseScore(string type)
    {
        targetsHit++;
        if(type == "HighValue")
        {
            score += highValue;
        }
        else
        {
            score += baseValue;
        }
    }

    void DestroyTutorial()
    {
        Destroy(tutorial);
    }
}
