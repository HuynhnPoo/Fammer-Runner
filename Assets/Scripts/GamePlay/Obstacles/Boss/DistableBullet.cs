using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistableBullet : MonoBehaviour
{
    private void Update()
    {
        DisableBullet();
    }


    //ham kiem tra khoang cach cua bullet
    void DisableBullet()
    {
        if (transform.position.z < -10)
        {
            ObjectPoolToPrefabs bullet = GameObject.FindObjectOfType<ObjectPoolToPrefabs>();
            if (bullet == null) return;
            bullet.ReturnObjectPool(gameObject);
        }
    }

    //ham thuc hien va cham voiw nhan vat neu 
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(TagInGame.playerTag))
        {

            Debug.Log("hien thi vatj the va cham laf gi" + other.gameObject.name);
            ObjectPoolToPrefabs bullet = GameObject.FindObjectOfType<ObjectPoolToPrefabs>();
            if (bullet == null) return;
            bullet.ReturnObjectPool(gameObject);

            GameManager.Instance.GameOver();
        }
    }
}
