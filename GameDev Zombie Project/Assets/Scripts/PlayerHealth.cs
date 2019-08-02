using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityStandardAssets.Characters.FirstPerson;

public class PlayerHealth : MonoBehaviour {

    GameObject player;
    GameObject Score;
    GameObject EnemysRemaining;
    GameObject Wave;
    GameObject Gun;
    GameObject Restart;
    GameObject cross;

    private Text textObj;
    public float Health = 100f;
    // Use this for initialization
    void Start () {
        textObj = GetComponent<Text>();
        textObj.text = "HEALTH: " + Health;
        player = GameObject.FindGameObjectWithTag("Player");
        Score = GameObject.FindGameObjectWithTag("Score");
        EnemysRemaining = GameObject.FindGameObjectWithTag("EnemysRemaining");
        Wave = GameObject.FindGameObjectWithTag("Wave");
        Gun = GameObject.FindGameObjectWithTag("Gun");
        Restart = GameObject.FindGameObjectWithTag("Restart");
        cross = GameObject.FindGameObjectWithTag("Cross");
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void HealthAdjust(int dmg)
    {
        Health -= dmg;
        textObj.text = "HEALTH: " + Health;
        if (Health <= 0)
        {
            player.tag = "PlayerDead";
            EnemysRemaining.GetComponent<Text>().enabled = false;
            Wave.GetComponent<Text>().enabled = false;
            player.GetComponent<CharacterController>().enabled = false;
            player.GetComponent<FirstPersonController>().enabled = false;
            player.GetComponent<Rigidbody>().isKinematic = false;
            player.GetComponent<Rigidbody>().mass = 1;
            player.GetComponent<Rigidbody>().angularDrag = .05f;
            textObj.enabled = false;
            Score.GetComponent<Score>().ScoreFinal();
            Restart.GetComponent<Text>().enabled = true;
            Restart.GetComponent<ReplayGame>().enabled = true;
            cross.SetActive(false);
            Gun.GetComponent<SimpleShoot>().enabled = false;
            Gun.AddComponent<Rigidbody>(); 
            

        }
    }


}
