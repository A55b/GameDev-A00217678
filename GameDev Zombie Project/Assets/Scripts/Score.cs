using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private Text textObj;
    public float ScorePoints = 100f;
    // Use this for initialization
    void Start()
    {
        textObj = GetComponent<Text>();
        textObj.text = "Score: " + ScorePoints;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ScoreAdjust()
    {

    }
}
