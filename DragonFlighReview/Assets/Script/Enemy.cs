using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed=3f;
    public GameObject effect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceY=moveSpeed*Time.deltaTime;
        transform.Translate(0,-distanceY,0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            

            GameObject explosion=Instantiate(effect,transform.position,Quaternion.identity);
            Destroy(explosion,1f);

            SoundManager.Instance.PlayDieSound();

            GameManager.instance.AddScore(100);
            Destroy(this.gameObject);
        }
    }

     private void OnBecameInvisible()
    {
        Destroy(this.gameObject);   
    }
}
