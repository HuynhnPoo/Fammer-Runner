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
        menuPause = FindGameObjectByName("PanelOption");

    }

    public static GameObject FindGameObjectByName(string name)
    {
        Transform[] transforms = Resources.FindObjectsOfTypeAll<Transform>();
        foreach (Transform t in transforms)
        {
            if (t.hideFlags == HideFlags.None && t.name == name)
            {
                return t.gameObject;
            }
        }
        return null;
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
