﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSE : MonoBehaviour
{

    public AudioClip sound1;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //左
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (audioSource.isPlaying) return;
            //音を鳴らす
            audioSource.PlayOneShot(sound1);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            //音を鳴らす
            audioSource.Stop();
        }
    }
}
