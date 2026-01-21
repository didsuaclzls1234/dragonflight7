using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    AudioSource audioSource;
    public AudioClip soundShot;
    public AudioClip soundDie;
    void Awake()
    {
       if(Instance==null)
       {
        Instance=this;
       }
    }

    void Start()
    {
        audioSource=GetComponent<AudioSource>();
    }
    public void PlayShotSound()
    {
        audioSource.PlayOneShot(soundShot);
    }
    public void PlayDieSound()
    {
        audioSource.PlayOneShot(soundDie);
    }
}
