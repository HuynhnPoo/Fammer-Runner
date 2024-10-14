using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PowerUp;
public class PlayerPowerUp : MonoBehaviour
{


    public ClashObstacles isPowerUp;

    private IPowerUp immplementPowerUp;
    // Start is called before the first frame update
    void Start()
    {
        isPowerUp = GetComponent<ClashObstacles>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckAndActivePowerUp();

    }

    void CheckAndActivePowerUp() 
    {
        if (isPowerUp == null) return;

        if (isPowerUp.currentPowerUp == PowerUpType.Immortal)
        {

            immplementPowerUp = GetComponent<Immortal>();
            immplementPowerUp.ActivePowerUp();

        }

        else if (isPowerUp.currentPowerUp == PowerUpType.DoubleCoin)
        {

            ActivateDoubleCoinPowerup();
        }

         else if (isPowerUp.currentPowerUp == PowerUpType.Magnet)
         {

            

         }
    }

    void ActivateDoubleCoinPowerup()
    {
        Coin[] allCoins = GameObject.FindObjectsOfType<Coin>();
         foreach (Coin coin in allCoins)
         {
            immplementPowerUp = coin;
            immplementPowerUp.ActivePowerUp();
         }
        
    }
}
