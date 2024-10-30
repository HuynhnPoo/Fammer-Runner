using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuiscControll : MusicBase
{

   public AudioClip jumpAClip;
    public AudioClip deathAClip;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

   public void PlayJumpAClip() 
    {
        audioSource.PlayOneShot(jumpAClip,1);
    }

    public void PlayDeathAClip() 
    {
        audioSource.PlayOneShot(deathAClip, 1);
    }
}
