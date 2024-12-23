using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSlider : SliderBase
{

    [SerializeField] private AudioSource music;
   
   
    protected override void Start()
    {
        base.Start();

        if (music != null) return;
        music = GameObject.FindAnyObjectByType<MusicBase>().GetComponent<AudioSource>();

        slider.value=music.volume;
    }

    protected override void OnChange(float value)
    {
       music.volume = value;
    }
  

}
