using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : SpawnObject
{
    private void Awake()
    {
        holderObject = GameObject.Find("SpawnObstacles").GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        AssignTime();
        InvokeRepeating(nameof(Spawn),timeStartSpawn,timeRepeatRate);
    }


    // khoi thoi gian
    void AssignTime()
    {
        timeStartSpawn = 2;
        timeRepeatRate = 2;
    }

    // thuc hien spawn
    public override void Spawn()
    {
        if (!GameManager.Instance.IsGameOver)
        { 
           GameObject obstacles= Instantiate(objectPrefabs[RandomIndex()], RandomPostion(), objectPrefabs[RandomIndex()].transform.rotation);

           obstacles.transform.parent=holderObject;// giu ostacles trong holder
        }
    }

    // tinh toan vi tri sinh ra 
    public override Vector3 RandomPostion()
    {
        float spawnPosX = minValueX + (RandomIndex() * spaceBetween);

        return new Vector3(spawnPosX,transform.position.y,transform.position.z);
    }

    // random index cua vat the
    public override int RandomIndex()
    {
       return Random.Range(0,2);
    }
}
