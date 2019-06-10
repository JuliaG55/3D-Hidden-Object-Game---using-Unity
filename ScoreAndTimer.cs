using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAndTimer : MonoBehaviour {

    public Text timerText;
    private float startTime;
    public static bool finished = false;
    private float finishedTime = 0;
    
    private float highScore1 = 0;
    private float highScore2 = 0;
    private float highScore3 = 0;
    private float highScore4 = 0;

    // Use this for initialization
    void Start () {
        //gives us the time since the application will start
        startTime = Time.time;


        highScore1 = PlayerPrefs.GetFloat("highScoreOne", 0);
        highScore2 = PlayerPrefs.GetFloat("highScoreTwo", 0);
        highScore3 = PlayerPrefs.GetFloat("highScoreThree", 0);
        highScore4 = PlayerPrefs.GetFloat("highScoreFour", 0);

        //if (gameObject.name == "HighScoreMenu")
        //{
        //    UpdateTheScore();
        //}

    }
	
	// Update is called once per frame
	void Update () {

        //if (gameObject.name == "HighScoreMenu")
        //{
        //    UpdateTheScore();
        //}

        if (finished)
        {
            SaveHightScore();
            //PlayerPrefs.SetFloat("bestTime", finishedTime);
            Debug.Log("Best time: " + PlayerPrefs.GetFloat("highScoreOne"));
            return;

        }
            float t = Time.time - startTime;
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f1"); // only two decimals in seconds
            finishedTime = t;
            timerText.text = minutes + ":" + seconds;

	}

    void SaveHightScore() {

        if(-finishedTime < -highScore1)
        {
            PlayerPrefs.SetFloat("highScoreFour", highScore3);
            PlayerPrefs.SetFloat("highScoreThree", highScore2);
            PlayerPrefs.SetFloat("highScoreTwo", highScore1);
            PlayerPrefs.SetFloat("highScoreOne", finishedTime);
        }
        else if (-finishedTime < -highScore2)
        {
            PlayerPrefs.SetFloat("highScoreFour", highScore3);
            PlayerPrefs.SetFloat("highScoreThree", highScore2);
            PlayerPrefs.SetFloat("highScoreTwo", finishedTime);
        }
        else if (-finishedTime < -highScore3)
        {
            PlayerPrefs.SetFloat("highScoreFour", highScore3);
            PlayerPrefs.SetFloat("highScoreThree", finishedTime);
        }
        else if (-finishedTime < -highScore4)
        {
            PlayerPrefs.SetFloat("highScoreFour", finishedTime);
        }
        else
        {
            Debug.Log("Your score is lower then top 4");
        }

    }


    //void UpdateTheScore()
    //{
    //    if (gameObject.name == "Score_1")
    //    {
    //        string score1 = PlayerPrefs.GetFloat("highScoreOne", 0).ToString();
    //        GetComponent<Text>().text = score1;
    //    }

    //    if (gameObject.name == "Score_2")
    //    {
    //        string score2 = PlayerPrefs.GetFloat("highScoreTwo", 0).ToString();
    //        GetComponent<Text>().text = score2;
    //    }

    //    if (gameObject.name == "Score_3")
    //    {
    //        string score3 = PlayerPrefs.GetFloat("highScoreThree", 0).ToString();
    //        GetComponent<Text>().text = score3;
    //    }

    //    if (gameObject.name == "Score_4")
    //    {
    //        string score4 = PlayerPrefs.GetFloat("highScoreFour", 0).ToString();
    //        GetComponent<Text>().text = score4;
    //    }
    //}

}
