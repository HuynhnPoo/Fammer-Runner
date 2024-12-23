using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MusicBackground : MusicBase
{

    [SerializeField] private AudioClip sound;
    private static MusicBackground instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        PlaySound();
    }

    void PlaySound()
    {
        audioSource.clip = sound;
        audioSource.Play();
    }
}
