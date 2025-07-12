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
        audioSource.PlayOneShot(jumpAClip);
    }
    // khi chet se bat am thanh
    public void PlayDeathAClip() 
    {
        audioSource.PlayOneShot(deathAClip, 1);
    }
}
