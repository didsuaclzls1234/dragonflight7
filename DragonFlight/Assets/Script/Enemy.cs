using UnityEngine;

public class Enemy : MonoBehaviour
{   public float movespeed = 2.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //움직임을 변수로 만들기
        float distanceY= movespeed * Time.deltaTime;
        //움직이기
        transform.Translate(0, -distanceY, 0);

    }
    
    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if(collision.gameObject.CompareTag("Bullet"))
    //     {
    //         //충돌한 미사일 삭제
    //         Destroy(collision.gameObject);
    //         //자기자신 삭제
    //         Destroy(gameObject);
    //     }
    // }

}
