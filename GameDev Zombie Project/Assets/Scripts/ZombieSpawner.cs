using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour {

    public GameObject SpawnPoint1;
    public GameObject SpawnPoint2;
    public GameObject SpawnPoint3;
    public GameObject SpawnPoint4;

    public GameObject ZombiePrefab;

    public int Zombiecount;
    public int ZombiesToSpawn = 5;

    float timer = 0.0f;

    // Use this for initialization
    void Start () {
        Zombiecount = ZombiesToSpawn;
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer >= 5.0f)
        {
            Spawn();
            timer = 0.0f;
        }
    }

    void Spawn() {
        int SpawnPointIndex = Random.Range(1, 5);
        Zombiecount++;

        Debug.Log(SpawnPointIndex);
        if (SpawnPointIndex == 1)
        {
            Instantiate(ZombiePrefab, SpawnPoint1.transform.position , SpawnPoint1.transform.rotation);
        }
        if (SpawnPointIndex == 2)
        {
            Instantiate(ZombiePrefab, SpawnPoint2.transform.position, SpawnPoint2.transform.rotation);
        }
        if (SpawnPointIndex == 3)
        {
            Instantiate(ZombiePrefab, SpawnPoint3.transform.position, SpawnPoint3.transform.rotation);
        }
        if (SpawnPointIndex == 4)
        {
            Instantiate(ZombiePrefab, SpawnPoint4.transform.position, SpawnPoint4.transform.rotation);
        }
    }
}
