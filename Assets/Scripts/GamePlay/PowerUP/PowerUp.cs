using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpType powerUpType;


    // khởi tạo danh sach PowerUpTupe
    public enum PowerUpType 
    {
        None,
        Immortal,
        DoubleCoin,
        Magnet
    }
}
