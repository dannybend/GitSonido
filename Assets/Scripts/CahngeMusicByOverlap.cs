using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CahngeMusicByOverlap : MonoBehaviour
{

    public AudioClip newTrack;

    private AudioManager theAM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {

        if (other.CompareTag("Player"))
        {
            
            theAM = FindObjectOfType<AudioManager>();
            theAM.ChangeBackgroundMusic(newTrack);

        }
        
    }
    
}
