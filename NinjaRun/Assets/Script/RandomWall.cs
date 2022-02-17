


using UnityEngine;

public class RandomWall : MonoBehaviour
{
    GameObject[] spawnPoint;
    public GameObject wall;
    public float minSpawnTime = 0.2f;
    public float maxSpawnTime = 1;
    private float lastSpawnTime = 0;
    private float spawnTime = 0;
    float TimeT = 0;

    // Use this for initialization
    void Start()
    {
        spawnPoint = GameObject.FindGameObjectsWithTag("wall");
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
        Instantiate(wall, new Vector3(10f,Random.Range(-8.7f,-5.65f)), Quaternion.identity);
        UpdateSpawnTime();

    }

    // Update is called once per frame
    void Update()
    {
        TimeT += Time.deltaTime;

        if (TimeT>0.4f)
        {
            TimeT = 0;
            Spawn();
        }
    }
}
