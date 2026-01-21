
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    void Start()
    {
        InvokeRepeating("SpawnEnemy",2f,1.5f);
    }

    public void SpawnEnemy()
    {
        float randomX=Random.Range(-2.5f,2.5f);
       Instantiate(EnemyPrefab,new Vector3(randomX,transform.position.y,0f),Quaternion.identity);
    }
    void Update()
    {
        
    }
}
