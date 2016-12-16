using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameAudio : MonoBehaviour {

    new AudioSource audio;
    public AudioClip GameMusic;


    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.PlayOneShot(GameMusic, 1F);
    }

    void Update()
    {
        if (!audio.isPlaying)
        {
            audio.PlayOneShot(GameMusic, 0.5F);
        }
    }



}
