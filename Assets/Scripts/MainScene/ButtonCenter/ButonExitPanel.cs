using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButonExitPanel : ButtonGuide
{
    public Button buttonExitMenu;
    protected override void Start()
    {
        menuGuide = GameObject.Find("Panel");
        base.button = GetComponent<Button>();
        base.button.onClick.AddListener(OnClick);
    }

    public override void OnClick()
    {
        if (onMenuGuide)
        {
            OffMenuGuide();
        }
    }

}
