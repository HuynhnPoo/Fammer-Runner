using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGuide : ButtonClick
{

    [SerializeField] protected GameObject menuGuide;
    protected static bool onMenuGuide = false;
    protected override void Start()
    {
        base.Start();

        menuGuide = transform.GetChild(1).gameObject;
    }

    //ham hien thi menu huong dan
    public override void OnClick()
    {
        if (!onMenuGuide)
        {
            OnMenuGuide();
        }
        else
        {
            OffMenuGuide();
        }
    }

    //ham bat menu
    public void OnMenuGuide()
    {
        onMenuGuide = true;
        menuGuide.SetActive(true);
    }

    //ham tat menu
    public void OffMenuGuide()
    {
        onMenuGuide = false;
        menuGuide.SetActive(false);
    }
}
