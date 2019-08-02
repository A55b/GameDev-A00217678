using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private Text textObj;
    private Text textObj2;
    float ScorePoints = 0f;
    public float ScoreAdd = 10f;
    public float ScoreDeath = 100f;
    // Use this for initialization
    void Start()
    {
        textObj = GetComponent<Text>();
        textObj2 = GameObject.FindGameObjectWithTag("FinalScore").GetComponent<Text>();
        textObj2.enabled = false;
        textObj.text = "Score: " + ScorePoints;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ScoreAdjustHit()
    {
    ScorePoints += ScoreAdd;
    textObj.text = "Score: " + ScorePoints;
    }

    public void ScoreAdjustDeath()
    {
        ScorePoints += ScoreDeath;
        textObj.text = "Score: " + ScorePoints;
    }

    public void ScoreMultiply()
    {
        ScoreAdd = ScoreAdd * 2;
        ScoreDeath = ScoreDeath * 2;
    }

    public void ScoreFinal()
    {
        textObj.enabled = false;
        textObj2.enabled = true;
        textObj2.text = "FINAL SCORE: " + ScorePoints;
    }
}
