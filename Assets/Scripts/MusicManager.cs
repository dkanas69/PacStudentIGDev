using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
  
    [SerializeField]
    private AudioSource baseMusic;
    bool Gameplaystart = true;
    [SerializeField]
    private AudioSource GameStartMusic;

    void Update()
    {
        if (Time.time > GameStartMusic.clip.length && Gameplaystart) {
            GameStartMusic.Stop();
            baseMusic.Play();
            Gameplaystart = false;
        }
    }
}
