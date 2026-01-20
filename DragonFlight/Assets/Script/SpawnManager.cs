using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enalbleSpawn = true;
    public GameObject enemyPrefab;//적 프리팹
    // public float[,] spawnPositions = new float[5,2]
    // {
    //     {-2f, 4f},
    //     {-1f, 4f},
    //     {0f, 4f},
    //     {1f, 4f},
    //     {2f, 4f}
    // };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //InvokeRepeating("spawn", 1f, 1f);
        InvokeRepeating("SpawnEnemy", 1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    // private void spawn()
    // {
    //     int index = Random.Range(0, spawnPositions.GetLength(0));
    //     Vector3 spawnPos = new Vector3(spawnPositions[index, 0], spawnPositions[index, 1], 0f);
    //     Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    // }
    public void SpawnEnemy()
    {
        float randomX = Random.Range(-2.5f, 2.5f);
        if(enalbleSpawn)
        {
            Instantiate(enemyPrefab, new Vector3(randomX,transform.position.y,0f), Quaternion.identity);
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
