using Unity.Mathematics;
using UnityEngine;

public class Launcher : MonoBehaviour
{
   public GameObject BulletPrefab;
    void Start()
    {
        InvokeRepeating("Shoot",1f,0.3f); 
    }

    void Shoot()
    {
        Instantiate(BulletPrefab,transform.position,quaternion.identity);
        SoundManager.Instance.PlayShotSound();
    }

       void Update()
    {
        
    }
}
