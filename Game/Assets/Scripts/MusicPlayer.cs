﻿using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour
{

    public AudioClip BackgroundMusic;

    // Use this for initialization
    void Start()
    {

        if (BackgroundMusic)
        {
            audio.clip = BackgroundMusic;
            audio.volume = 0.1f;
            audio.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
