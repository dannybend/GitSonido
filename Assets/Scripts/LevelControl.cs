using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{

    public int index;
    public string levelName;

    void OnTriggerEnter(Collider other) 
    {

        if (other.CompareTag("Player"))
        {
            
            SceneManager.LoadScene(index);

            //Scene.LoadScene(levelName);

        }

    }

}
