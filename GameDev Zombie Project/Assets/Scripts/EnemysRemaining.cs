using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemysRemaining : MonoBehaviour {

    private Text textObj;
    public int Enemys = 0;
    // Use this for initialization
    void Start () {
        textObj = GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {
        //textObj.text = "Enemys Remaining: " + GameObject.FindGameObjectsWithTag("Zombie").Length ;
        
    }

    public void EnemyAdjust()
    {
        Enemys--;
        textObj.text = "Enemys Remaining: " + Enemys.ToString();
    }

    public void EnemyStart(int i)
    {
        Enemys = i;
        textObj.text = "Enemys Remaining: " + Enemys.ToString();
    }

    public void EnemyInbound()
    {
        textObj.text = "Enemys Inbound! ";
    }
}
