using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip audioChoose;
    public AudioClip audioFalse;
    public AudioClip audioAttack;
    public AudioClip audioDie;

    AudioSource audioSource;

    private void Awake()
    {
        this.audioSource = GetComponent<AudioSource>();
    }
}
