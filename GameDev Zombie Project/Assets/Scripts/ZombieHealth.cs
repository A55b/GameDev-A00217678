using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieHealth : MonoBehaviour
{
    float health = 3;
    private ParticleSystem Blood;
    GameObject Enemys;
    GameObject Score;

    bool deathtimer = false;
    float timer = 0f;
    // Use this for initialization
    void Start()
    {
        Blood = GetComponent<ParticleSystem>();
        Blood.Stop();
        Enemys = GameObject.Find("Enemys Remaining");
        Score = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        if (deathtimer == true)
        {
            timer += Time.deltaTime;
            if (timer >= 5.0f)
            {
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        //Debug.Log("Coll");
        if (col.gameObject.tag == "Bullet")
        {
            Object.Destroy(col.gameObject);
            Blood.Play();
            Debug.Log("Hit");
            health--;
            Score.GetComponent<Score>().ScoreAdjustHit();
            if (health <= 0)
            {
                gameObject.GetComponent<BoxCollider>().enabled = false;
                gameObject.GetComponent<NavMeshAgent>().enabled = false;
                gameObject.GetComponent<Animator>().enabled = false;
                deathtimer = true;
                transform.gameObject.tag = "None";
                Enemys.GetComponent<EnemysRemaining>().EnemyAdjust();
                Score.GetComponent<Score>().ScoreAdjustDeath();
            }
        }
    }
}
