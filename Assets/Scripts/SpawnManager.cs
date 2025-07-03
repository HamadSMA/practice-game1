using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("RandomSpawn", 2, 1.5f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Spawn random enemeies at random locations
    void RandomSpawn()
    {
        int enemyIndex;
        float spawnPos;
        float rangeZ = 2.0f;
        enemyIndex = Random.Range(0, enemyPrefabs.Length);
        spawnPos = Random.Range(-rangeZ, rangeZ);
        Instantiate(enemyPrefabs[enemyIndex], new Vector3(5.5f, 0.35f, spawnPos), enemyPrefabs[enemyIndex].transform.rotation);
    }
}
