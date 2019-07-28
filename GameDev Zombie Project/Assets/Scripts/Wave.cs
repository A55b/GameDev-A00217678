using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wave : MonoBehaviour {

    private Text textObj;
    public int WaveNo = 1;
    // Use this for initialization
    void Start()
    {
        textObj = GetComponent<Text>();
        textObj.text = "WAVE: " + WaveNo;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void AmmoAdjust()
    {

    }
}
