using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyBoss : MonoBehaviour
{

    // xoa boss
    public void DestroyBossSpawn() 
    {
        Destroy(gameObject);
    }
}
