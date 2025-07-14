using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicEffect : MusicBase
{

    [SerializeField] private AudioClip jumpAClip;
    [SerializeField] private AudioClip deathAClip;


    // khi nhay se bat am thanh
    public void PlayJumpAClip()
    {
        if (audioSource == null) { Debug.LogWarning("hien thi ra  nhay cua nhan vat " + jumpAClip); return; }
        audioSource.PlayOneShot(jumpAClip);
    }
    // khi chet se bat am thanh
    public void PlayDeathAClip()
    {
        if (audioSource == null) { Debug.LogWarning("hien thi ra  nhay cua nhan vat " + jumpAClip); return; }
        audioSource.PlayOneShot(deathAClip, 1);
    }
}
