using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusicOnLoad : MonoBehaviour
{

    public AudioClip newTrack;

    private AudioManager theAM;
    // Start is called before the first frame update
    void Start()
    {
        
        theAM = FindObjectOfType<AudioManager>();

        if (newTrack !=null)
        {
            theAM.ChangeBackgroundMusic(newTrack);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
