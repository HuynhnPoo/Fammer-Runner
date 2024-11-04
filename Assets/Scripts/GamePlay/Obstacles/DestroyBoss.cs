using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyBoss : MonoBehaviour
{
    public void DestroyBossSpawn() 
    {
        Destroy(gameObject);
    }
}
