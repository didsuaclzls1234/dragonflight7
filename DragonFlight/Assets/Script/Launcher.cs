using Unity.Mathematics;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject Bullet;

    void Start()
    {
        //InvokeRepeating("함수이름",초기지연시간,지연할 시간);
        InvokeRepeating("Shoot", 0.3f, 0.3f);
    }


//미사일 프리팹, 런쳐 포지션,방향 값 없음
    void Shoot()
    {
        Instantiate(Bullet, transform.position, quaternion.identity);
        SoundManager.Instance.SoundBullet();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
