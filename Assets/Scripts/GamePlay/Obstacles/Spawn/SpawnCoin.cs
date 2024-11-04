using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : SpawnObject
{
    private void Awake()
    {
        if (holderObject != null) return;
        holderObject = GameObject.Find("SpawnCoin").GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        AssignTime();
        InvokeRepeating(nameof(Spawn), timeStartSpawn, timeRepeatRate);
    }
 // thiet lap thoiw gian
    void AssignTime() 
    {
        timeStartSpawn = 1;
        timeRepeatRate = 1.5f;
    }

   // tao ra coin
    public override void Spawn()
    {
        if (!GameManager.Instance.IsGameOver)
        {
            GameObject obstacles = Instantiate(objectPrefabs[0], RandomPostion(), objectPrefabs[0].transform.rotation);

            obstacles.transform.parent = holderObject;// giu ostacles trong holder
        }
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
