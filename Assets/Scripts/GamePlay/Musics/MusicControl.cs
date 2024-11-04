using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MusicBase
{

   [SerializeField] private AudioClip jumpAClip;
   [SerializeField] private AudioClip deathAClip;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }


    // khi nhay se bat am thanh
     public void PlayJumpAClip() 
    {
        audioSource.PlayOneShot(jumpAClip,1);
    }


    // khi chet se bat am thanh
    public void PlayDeathAClip() 
    {
        audioSource.PlayOneShot(deathAClip, 1);
    }
}
