using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class PlayerSFX : MonoBehaviour
{
    /*
    Dictionary<int, AudioClip> playerSFXDict = new Dictionary<int, AudioClip>();

    void Start()
    {
        AddToDict(AudioClip.);
    }

    private void AddToDict(AudioClip sfx)
    {
        if (!playerSFXDict.ContainsValue(sfx))
        {
            playerSFXDict.Add(0, sfx);
            Debug.Log("it diden't contain" + sfx);
        }
        else
        {
            Debug.Log("Already contains" + sfx);
        }
    }

    public void PlayAudio(int clip)
    {
        AudioSource audiosource;
        AudioClip[] geluid;
        audiosource = Camera.main.transform.Find("EmptyCamera").GetComponent<AudioSource>();
        //AudioSource audio = GetComponent<AudioSource> ();
        geluid = new AudioClip[]
        {
            (AudioClip)Resources.Load ("geluid/ontplof") as AudioClip,
            (AudioClip)Resources.Load ("geluid/spacesound") as AudioClip,
            (AudioClip)Resources.Load ("geluid/snoop") as AudioClip
        };
        //audio.PlayOneShot (geluid [clip], 0.7f);
        audiosource.clip = geluid[clip];
        audiosource.Play();
    }
    */
}