using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPanelGuideBtn : ButtonGuide
{
    protected override void Start()
    {
        base.Start();
    }
    public override void OnClick()
    {
        OffMenuGuide();
    }
}
