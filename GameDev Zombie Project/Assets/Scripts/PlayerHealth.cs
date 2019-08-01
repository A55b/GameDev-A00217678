using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    private Text textObj;
    public float Health = 100f;
    // Use this for initialization
    void Start () {
        textObj = GetComponent<Text>();
        textObj.text = "HEALTH: " + Health;
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void HealthAdjust(int dmg)
    {
        Health -= dmg;
        textObj.text = "HEALTH: " + Health;
    }
}
