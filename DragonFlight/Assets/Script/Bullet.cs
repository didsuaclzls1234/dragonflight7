using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1;
    public GameObject effect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,moveSpeed * Time.deltaTime ,0);
    }

    //화면 밖으로 나가면 호출되는함수
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {   
            //이펙트 생성
            GameObject go=Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(go,1f);

            //싱글톤 함수 호출
            SoundManager.Instance.SoundDie();
            
            //점수
            GameManager.instance.AddScore(100);
            
            //적 충돌
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
