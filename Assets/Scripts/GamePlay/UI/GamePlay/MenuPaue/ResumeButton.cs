using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeButton : ButtonPause
{

    // ham thuc hien tiep tuc de choi game
    public override void OnClick()
    {
      if (GameManager.Instance.IsPaused) 
        {
            GameManager.Instance.IsPaused = false;
            menuPause.SetActive(false);
            Time.timeScale = 1;
        }
      
    }
}
