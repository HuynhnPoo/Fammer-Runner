using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPause : ButtonClick
{
    private bool isPaused=false;

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

    public void ChangePaused()
    {
        if (!isPaused)
        {
            isPaused = true;
            menuPause.SetActive(true);
            Time.timeScale = 0;
        }

        else
        {
            isPaused = false;
            menuPause.SetActive(false);
            Time.timeScale = 1; 
        }
    }

}
