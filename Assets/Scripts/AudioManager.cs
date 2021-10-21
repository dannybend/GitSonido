using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource backgroundMusic;

    // Start is called before the first frame update
    void Start()
    {

        DontDestroyOnLoad(gameObject);

     if (FindObjectsOfType<AudioManager>().Length > 1)
        {
            Destroy(gameObject);
        }
        
    }

    public void ChangeBackgroundMusic(AudioClip music)
    {

        if (backgroundMusic.clip.name == music.name)
        {
            return;
        }

        backgroundMusic.Stop();
        backgroundMusic.clip = music;
        backgroundMusic.Play();

    }

}
