using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //x쪽값 설정 vectro 방향*시간*스피드
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        transform.Translate(distanceX, 0, 0);
    }

    //istrigger 아닌 충돌
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            //충돌한 적 삭제
            Destroy(collision.gameObject);
            //자기자신 삭제
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            //적 삭제
            Destroy(collision.gameObject);

            //플레이어 삭제
            Destroy(gameObject);


        }
    }
}
