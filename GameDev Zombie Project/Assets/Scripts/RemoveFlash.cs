using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFlash : MonoBehaviour {

    float timeon = 0;

    // Update is called once per frame
    void Update()
    {
        timeon += Time.deltaTime;
        if (timeon > 1.0f)
        {
            FlashDelete();
        }
    }

    void FlashDelete()
    {
        Destroy(gameObject);
    }
}
