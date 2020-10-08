using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Kaylyn McCune - 100662337
//Changes the score display on screen based on how long it takes the player to complete the maze

public class ScoreDisplay : MonoBehaviour
{
    //declare variables
    public int score;
    public float scoreTimer;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //initialize
        score = 1000;
        scoreText.text = "Score: " + score;
        scoreTimer = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //decrease the score timer by the time since the last frame
        scoreTimer -= Time.deltaTime;

        //check to see if the timer has run out
        if(scoreTimer <= 0)
        {
            //decrease score by 1
            score--;
            //reset time
            scoreTimer = 1.0f;
        }

        //update the score text
        scoreText.text = "Score: " + score;
        
    }
}
