using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wave : MonoBehaviour {

    private Text textObj;
    int WaveNo = 0;
    bool wavecount = true;
    GameObject spawner;
    float timer = 10.0f;
    // Use this for initialization
    void Start()
    {
        //spawner = GameObject.Find("Zombie Spawner");
        textObj = GetComponent<Text>();
        textObj.text = "WAVE: " + WaveNo;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (wavecount)
        {
            timer -= Time.deltaTime;
            if (timer >= 0)
            {
                Debug.Log(timer);
                textObj.text = "NEXT WAVE: " + timer.ToString("#.0");
            }
            else
            {
                textObj.text = "NEXT WAVE: 0" ;
            }
        }
    }

    public void WaveAdjust()
    {
        wavecount = false;
        WaveNo++;
        //spawner = GameObject.Find("Zombie Spawner");
        textObj = GetComponent<Text>();
        textObj.text = "WAVE: " + WaveNo;
    }

    public void WaveCountDown()
    {
        wavecount = true;
        timer = 10;
    }
}
