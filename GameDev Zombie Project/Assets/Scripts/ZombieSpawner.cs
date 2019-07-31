using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour {

    public GameObject SpawnPoint1;
    public GameObject SpawnPoint2;
    public GameObject SpawnPoint3;
    public GameObject SpawnPoint4;

    public GameObject ZombiePrefab;

    GameObject wave;
    GameObject Enemys;

    public int ZombieCount;
    public int ZombiesToSpawn = 5;
    public int WaveNo = 0;
    //public int ZombiesAlive = 1;

    float SpawnTimer = 5.0f;
    float timer = 0.0f;
    
    bool BetweenWave = true;
    // Use this for initialization
    void Start () {
        ZombieCount = ZombiesToSpawn;
        wave = GameObject.Find("WAVE");
        Enemys = GameObject.Find("Enemys Remaining");
        
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (BetweenWave)
        {
            if (timer >= 10.0f)
            {
                Debug.Log("WaveStart");
                BetweenWave = false;
                timer = 0f;
                wave.GetComponent<Wave>().WaveAdjust();
                Enemys.GetComponent<EnemysRemaining>().EnemyStart(ZombieCount);
            }
        }

        if (timer >= SpawnTimer && BetweenWave == false)
        {
            if(ZombieCount > 0)
            {
                Spawn();
                timer = 0.0f;
                ZombieCount--;
            }
            
        }

        if (ZombieCount == 0 && GameObject.FindGameObjectsWithTag("Zombie").Length == 0)
        {
            Debug.Log("WaveComplete");
            WaveNo++;
            wave.GetComponent<Wave>().WaveCountDown();
            ZombiesToSpawn += 10;
            ZombieCount = ZombiesToSpawn;
            BetweenWave = true;
            timer = 0.0f;
            SpawnTimer = SpawnTimer * .8f;
            Enemys.GetComponent<EnemysRemaining>().EnemyInbound();
        }
    }

    void Spawn() {
        int SpawnPointIndex = Random.Range(1, 5);

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
