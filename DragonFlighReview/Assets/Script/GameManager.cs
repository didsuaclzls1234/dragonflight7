using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText;
    private int score=0;
    void Awake()
    {
        if(instance==null)
        {
            instance=this;
        }
    }
    public void AddScore(int newScore)
    {
        score+=newScore;
        scoreText.text="Score:"+score;
        if(score>=1000)
        {
            SceneManager.LoadScene(1);//2번째 씬
        }
    }   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
