using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullets : MonoBehaviour {

    float timeon = 0;

    // Update is called once per frame
    void Update()
    {
        timeon += Time.deltaTime;
        if (timeon > 5.0f)
        {
            BulletDelete();
        }
    }

    void BulletDelete()
    {
        Destroy(gameObject);
    }
}
