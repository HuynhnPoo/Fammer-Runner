using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoss : SpawnObject
{
   
    private void Awake()
    {
        if ( holderObject != null) return;

        holderObject = GameObject.Find("SpawnBoss").GetComponent<Transform>();

    }

    // sinh ra boss
    public override void Spawn()
    {
        if (!GameManager.Instance.IsGameOver)
        {
            GameObject obstacles = Instantiate(objectPrefabs[RandomIndex()], RandomPostion(), objectPrefabs[RandomIndex()].transform.rotation);

            obstacles.transform.parent = holderObject;// giu ostacles trong holder
        }
    }

    public void DisabledBoss()
    {
       
    }
    // ke thua method cua lop SpawnObject de tinh random vi tri X sinh ra coin
    public override Vector3 RandomPostion()
    {
        return base.RandomPostion();
    }

    // ke thua method cua lop SpawnObject de tinh  radom index vi tri coin
    public override int RandomIndex()
    {
        return base.RandomIndex();
    }
}
