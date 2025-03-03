using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PowerUp;

public class TextPowerup : TextBase
{

    public ClashObstacles currentPowerUp;

    protected override void Start()
    {
        base.Start();
        if (currentPowerUp == null)
            currentPowerUp = GameObject.FindAnyObjectByType<ClashObstacles>();
    }

    private void Update()
    {
        DisplayPowerup(currentPowerUp.currentPowerUp);
    }

    void DisplayPowerup(PowerUpType powerup)
    {
        text.text = powerup.ToString();
    }
}
