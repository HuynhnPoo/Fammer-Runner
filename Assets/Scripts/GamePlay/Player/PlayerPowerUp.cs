using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PowerUp;
public class PlayerPowerUp : MonoBehaviour
{
    private ClashObstacles isPowerUp;
    private ActiveMagnet magnet;

    private IPowerUp immplementPowerUp;
    // Start is called before the first frame update
    void Start()
    {
        LoadComponent();
    }

    //khỏi tạo compoment
    void LoadComponent()
    {
        isPowerUp = GetComponent<ClashObstacles>();
        magnet = FindObjectOfType<ActiveMagnet>().GetComponent<ActiveMagnet>();

    }

    // Update is called once per frame
    void Update()
    {
        CheckAndActivePowerUp();// thuc hien powerup
    }

    void CheckAndActivePowerUp() 
    {
        if (isPowerUp == null) return;  //kiem tra rỗng

        ImplementPowerUp();//  hàm thực hiện powerup
    }


    // kiểm tra va thuc hien các powerup
    void ImplementPowerUp()
    {
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
            immplementPowerUp = magnet;
            immplementPowerUp.ActivePowerUp();

        }
    }


    // khởi tạo coin và duyetj tung phần tử trong mảng coin
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
