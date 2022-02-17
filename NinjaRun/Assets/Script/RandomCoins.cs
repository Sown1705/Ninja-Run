


using UnityEngine;

public class RandomCoins : MonoBehaviour
{
    GameObject[] spawnPoint;
    GameObject[] battery;
    public GameObject coin;
    public GameObject batterys;
    public float minSpawnTime = 0.2f;
    public float maxSpawnTime = 1;
    private float lastSpawnTime = 0;
    private float spawnTime = 0;
    
    // Use this for initialization
    void Start()
    {
        spawnPoint = GameObject.FindGameObjectsWithTag("recoins");
        battery = GameObject.FindGameObjectsWithTag("battery");
        UpdateSpawnTime();
    }

    void UpdateSpawnTime()
    {
        lastSpawnTime = Time.time;
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    void Spawn()
    {
    
        int point = Random.Range(0, spawnPoint.Length);
        int btr = Random.Range(0, battery.Length);
        Instantiate(coin, spawnPoint[point].transform.position, Quaternion.identity);
        if (BatteryController.instance.count <= 4 && Time.time%2==0)
        {
            Instantiate(batterys, battery[btr].transform.position, Quaternion.identity);
        }
        UpdateSpawnTime();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= lastSpawnTime + spawnTime)
        {
            Spawn();
        }
    }
}
