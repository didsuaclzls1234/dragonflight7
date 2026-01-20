using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;//싱글톤변수
    AudioSource audioSource;//컴포넌트 변수로 담는다.
    
    public AudioClip soudndBullet;//폭발 사운드
    public AudioClip soundDie;//죽는 사운드
    void Awake()
    {
        if(Instance==null)
        {
            Instance=this;
           
        }
       
    }
    void Start()
    {
         audioSource=GetComponent<AudioSource>();//AudioSource컴포넌트 가져오기
    }

    public void SoundDie()
    {
        audioSource.PlayOneShot(soundDie);//몬스터 죽는소리
    }
    public void SoundBullet()
    {
        audioSource.PlayOneShot(soudndBullet);//폭발 소리
    }
}
