using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log(PlayerPrefs.GetFloat("highScoreOne", 0) + ", " + PlayerPrefs.GetFloat("highScoreTwo", 0) + ", " + PlayerPrefs.GetFloat("highScoreThree", 0) + ", " + PlayerPrefs.GetFloat("highScoreFour", 0));
        if (gameObject.name == "Score_1")
        {
            string score1 = PlayerPrefs.GetFloat("highScoreOne", 0) + "";
            GetComponent<Text>().text = score1;
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (gameObject.name == "Score_1")
        {
            string score1 = PlayerPrefs.GetFloat("highScoreOne", 0) + "";
            GetComponent<Text>().text = score1;
        }

        if (gameObject.name == "Score_2")
        {
            string score2 = PlayerPrefs.GetFloat("highScoreTwo", 0).ToString();
            GetComponent<Text>().text = score2;
        }

        if (gameObject.name == "Score_3")
        {
            string score3 = PlayerPrefs.GetFloat("highScoreThree", 0).ToString();
            GetComponent<Text>().text = score3;
        }

        if (gameObject.name == "Score_4")
        {
            string score4 = PlayerPrefs.GetFloat("highScoreFour", 0).ToString();
            GetComponent<Text>().text = score4;
        }
    }
}
