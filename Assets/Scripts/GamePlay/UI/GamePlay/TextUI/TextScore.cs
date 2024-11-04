using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScore : TextBase
{
   public ScoreKM scoreKM;

    protected override void Start()
    {
        base.Start();
        if (scoreKM == null)
        scoreKM = GameObject.FindObjectOfType<ScoreKM>().GetComponent<ScoreKM>();
    }
    // Update is called once per frame
    void Update()
    {
        text.SetText("Score: "+scoreKM.Score);   
    }
}
