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

    public void Awake()
    {
        this.audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(string action)
    {
        switch (action)
        {
            case "CHOOSE":
                audioSource.clip = audioChoose;
                break;
            case "FALSE":
                audioSource.clip = audioFalse;
                break;
            case "ATTACK":
                audioSource.clip = audioAttack;
                break;
            case "DIE":
                audioSource.clip = audioDie;
                break;
        }
        audioSource.Play();
    }

}
