using UnityEngine;

public class Spawner : MonoBehaviour
{
 
    public GameObject objectToSpawn;

    public Vector3 spawnRangeMin;
    public Vector3 spawnRangeMax;

  
    public float spawnInterval = 2.0f;

    private float timer;

    void Start()
    {
        timer = spawnInterval; 
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            SpawnObject();
            timer = spawnInterval; 
        }
    }

    void SpawnObject()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(spawnRangeMin.x, spawnRangeMax.x),
            Random.Range(spawnRangeMin.y, spawnRangeMax.y),
            Random.Range(spawnRangeMin.z, spawnRangeMax.z)
        );

        Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
    }

   
}


