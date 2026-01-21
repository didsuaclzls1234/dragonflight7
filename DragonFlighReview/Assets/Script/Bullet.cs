using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float BulletSpeed =1f;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,BulletSpeed*Time.deltaTime,0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {   
        
        if(collision.gameObject.CompareTag("Enemy"))
        {   
        
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);   
    }
}
