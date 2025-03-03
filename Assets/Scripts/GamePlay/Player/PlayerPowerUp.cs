using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static PowerUp;
public class PlayerPowerUp : MonoBehaviour
{
    private ClashObstacles isPowerUp;
    private ActiveMagnet magnet;

    private IPowerUp immplementPowerUp;

    [SerializeField]private GameObject panelPowerup;
   [SerializeField] private Image imgPanel;
    private void OnEnable()
    {
        panelPowerup  = FindGameObjectByNameHide.FindGameObjectByName("PanelPowerup");
       
    }
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
            panelPowerup.SetActive(true);// bat thong bao powerup
            
            immplementPowerUp = GetComponent<Immortal>();
            immplementPowerUp.ActivePowerUp();// thuc hien powerup immotal

        }

        else if (isPowerUp.currentPowerUp == PowerUpType.DoubleCoin)
        {
            panelPowerup.SetActive(true);// bat thong bao powerup

            ActivateDoubleCoinPowerup();//thuc hien double coin
        }

        else if (isPowerUp.currentPowerUp == PowerUpType.Magnet)
        {
            panelPowerup.SetActive(true); // bat thong bao powerup

            immplementPowerUp = magnet;
            immplementPowerUp.ActivePowerUp();//thu hien magnet

        }
        else
        {
            panelPowerup.SetActive(false);// tat thong bao powerup
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
