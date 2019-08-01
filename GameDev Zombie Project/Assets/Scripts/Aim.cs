using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour {
    Vector3 startPoint = new Vector3(0.38f, -0.75f, 0.72f);
    Vector3 endPoint = new Vector3(0, -0.487f, 0.468f);
    public float speed = .5f;
    Vector3 CurrentPoint;
    bool move = false;
    bool retur = false;
    GameObject Crosshairs;
    // Use this for initialization
    void Start () {
        Crosshairs = GameObject.Find("Crosshairs");
    }
	
	// Update is called once per frame
	void Update () {
        //print("aim");
        CurrentPoint = transform.localPosition;
        //float distCovered = (Time.time - startTime) * speed;
        //fracJourney = distCovered / journeyLength;
        //Debug.Log(fracJourney);
        if (Input.GetButtonDown("Fire2"))
        {
            Crosshairs.SetActive(false);

            print("aim key was pressed");
            move = true;
        }

        if (Input.GetButtonUp("Fire2"))
        {
            
            print("aim key was let go");
            move = false;
            retur = true;
        }

        if (move==true)
        {
            transform.localPosition = Vector3.Lerp(CurrentPoint, endPoint, speed); // * Time.deltaTime);
            
        }

        if (move == false && retur == true)
        {
            transform.localPosition = Vector3.Lerp(CurrentPoint, startPoint, speed);// * Time.deltaTime);
            if (CurrentPoint == startPoint)
            {
                
                retur = false;
                print("stop move");
            }
            else if (CurrentPoint.x >=.3f)
            {
                Crosshairs.SetActive(true);
            }


        }

    }
}
