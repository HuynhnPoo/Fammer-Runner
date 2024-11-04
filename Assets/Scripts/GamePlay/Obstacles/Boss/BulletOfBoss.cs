using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletOfBoss : MonoBehaviour
{
    [SerializeField] private ObjectPoolToPrefabs bulletPool;
    public Transform bulletPos;

    private void Awake()
    {
        if (bulletPool != null) return;

        bulletPos =GameObject.Find("Bullet_Pos").GetComponent<Transform>() ;
        bulletPool = GetComponent<ObjectPoolToPrefabs>();
    }


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnBullet),1,1);
    }

    //ham su ly khi sinh ra dan
    void SpawnBullet()
    {
        GameObject bullet = bulletPool.GetOjectPool();
        bullet.transform.position = bulletPos.transform.position;
        bullet.transform.rotation  = Quaternion.Euler(0,0,0) ;

    }


}
