using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //싱글톤
    public static GameManager instance;
    public Text scoreText;

    int score=0;//점수

    void Awake()
    {
        if(instance==null)//정적으로 자신을 체크
        {
            instance=this;//자가자신을 인스턴스해서 저장
        }
    }

    public void AddScore(int num)
    {
        score+=num;
        scoreText.text="Score : "+score;//텍스트에 반영
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
