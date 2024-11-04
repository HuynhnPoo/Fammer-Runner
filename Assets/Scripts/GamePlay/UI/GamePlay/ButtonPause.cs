using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class ButtonPause : ButtonClick
{


    public GameObject menuPause;

    private void OnEnable()
    {
        LoadMenuPause();
    }


    void LoadMenuPause()
    {
        if (menuPause != null) return;
        menuPause = FindGameObjectByNameHide.FindGameObjectByName(TagInGame.pauseGameTag);

    }

    public override void OnClick()
    {
        ChangePaused();
    }

    // ham pause game
    public void ChangePaused()
    {
        if (!GameManager.Instance.IsPaused)
        {
            GameManager.Instance.IsPaused = true;
            menuPause.SetActive(true);
            Time.timeScale = 0;

        }

        else
        {
            GameManager.Instance.IsPaused = false;
            menuPause.SetActive(false);
            Time.timeScale = 1;
        }
    }

}
