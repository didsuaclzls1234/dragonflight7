using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed=5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceX=Input.GetAxis("Horizontal")*moveSpeed*Time.deltaTime;
        float distanceY=Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;
        transform.Translate(distanceX, distanceY, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
           
           Destroy(collision.gameObject);
           Destroy(this.gameObject);
        }
    }
}
