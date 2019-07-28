using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoText : MonoBehaviour
{

    private Text textObj;
    public int Ammo = 100;
    // Use this for initialization
    void Start()
    {
        textObj = GetComponent<Text>();
        textObj.text = "AMMO: " + Ammo;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void AmmoAdjust()
    {

    }
}
