using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowwerUp : SpawnObject
{
    private void Awake()
    {
        holderObject = GameObject.Find("SpawnPowerUp").GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        AssignTime();
        InvokeRepeating(nameof(Spawn), timeStartSpawn, timeRepeatRate);
    }
    // khoi thoi gian
    void AssignTime()
    {
        timeStartSpawn = 10;
        timeRepeatRate = 15;
    }
    
    public override void Spawn()
    {
        if (!GameManager.Instance.IsGameOver)
        {
            GameObject obstacles = Instantiate(objectPrefabs[RandomIndex()], RandomPostion(), objectPrefabs[RandomIndex()].transform.rotation);

            obstacles.transform.parent = holderObject;// giu ostacles trong holder
        }
    }
    public override Vector3 RandomPostion()
    {
        return base.RandomPostion();
    }
    public override int RandomIndex()
    {
        return base.RandomIndex();
    }


   
}
