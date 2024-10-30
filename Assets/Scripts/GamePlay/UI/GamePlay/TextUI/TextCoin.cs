using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCoin : TextBase
{
    // Update is called once per frame
    void Update()
    {
        DisplayCoin();
    }
    void DisplayCoin()
    {
        string coin = GameManager.Instance.CurrentCoin.ToString();
        text.SetText("Coin: " + coin); // hie thi coin len tren man hinh
    }
}
