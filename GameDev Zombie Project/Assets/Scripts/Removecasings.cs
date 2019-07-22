using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Removecasings : MonoBehaviour {

    float timeon = 0;

	// Update is called once per frame
	void Update () {
         timeon += Time.deltaTime;
        if (timeon > 3.0f)
        {
            CasingDelete();
        }
	}

    void CasingDelete()
    {
        Destroy(gameObject);
    }
}
