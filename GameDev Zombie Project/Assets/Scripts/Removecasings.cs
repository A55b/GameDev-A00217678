using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Removecasings : MonoBehaviour {

    float timeon = 0;
    private BoxCollider Soundtrigger;
    private AudioSource m_AudioSource;
    public AudioClip Casing1;
    public AudioClip Casing2;
    public AudioClip Casing3;

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        Soundtrigger = GetComponent<BoxCollider>();
    }
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

    void OnTriggerEnter(Collider col)
    {
        //Debug.Log("Coll");
        if (col.gameObject.tag == "Floor")
        {
            int SoundIndex = Random.Range(1, 3);

            //Debug.Log(SoundIndex);
            if (SoundIndex == 1)
            {
                m_AudioSource.PlayOneShot(Casing1);
                Soundtrigger.enabled = false;
            }
            else if (SoundIndex == 2)
            {
                m_AudioSource.PlayOneShot(Casing2);
                Soundtrigger.enabled = false;
            }
            else if (SoundIndex == 3)
            {
                m_AudioSource.PlayOneShot(Casing3);
                Soundtrigger.enabled = false;
            }
            else
            {
                m_AudioSource.PlayOneShot(Casing1);
                Soundtrigger.enabled = false;
            }
        }
    }
}
