using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBase : MonoBehaviour
{
    public AudioSource audioSource;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        if (audioSource == null)
        audioSource = GetComponent<AudioSource>();
    }
}
