using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;

    private AudioSource audioSource;


    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        //Debug.Log("music player still goes "+name);
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }

    void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = levelMusicChangeArray[level];
        //Debug.Log("Playing clip: " + thisLevelMusic); ;

        if (thisLevelMusic)
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

}
