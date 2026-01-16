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
}
