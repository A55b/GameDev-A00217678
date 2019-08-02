using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArm : MonoBehaviour {
    private BoxCollider Soundtrigger;
    private AudioSource m_AudioSource;
    public AudioClip Hit;
    public AudioClip Thud;
    bool cooldown = false;
    float timer;
    // Use this for initialization
    void Start () {
        m_AudioSource = GetComponent<AudioSource>();
        Soundtrigger = GetComponent<BoxCollider>();
    }
	
	// Update is called once per frame
	void Update () {
        if (cooldown)
        {
            timer += Time.deltaTime;
            if (timer >= 1.8f)
            {
                Soundtrigger.enabled = true;
                cooldown = false;
            }
        }
        else if (this.transform.root.GetComponent<Animator>().enabled == false)
        {
            Soundtrigger.enabled = false;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        //Debug.Log("Coll");
        if (col.gameObject.tag == "Player")
        {
            m_AudioSource.PlayOneShot(Thud);
            m_AudioSource.PlayOneShot(Hit);
            cooldown = true;
            timer = 0;
            Soundtrigger.enabled = false;
        }

        if (col.gameObject.tag == "PlayerDead")
        {
            m_AudioSource.PlayOneShot(Thud);
            cooldown = true;
            timer = 0;
            Soundtrigger.enabled = false;
        }
    }
}
