using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : SpawnObject
{
    private void Awake()
    {
        if (holderObject != null) return;
        holderObject = GameObject.Find("SpawnObstacles").GetComponent<Transform>();
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
        timeStartSpawn = 2;
        timeRepeatRate = 2;
    }

    // thuc hien spawn
    public override void Spawn()
    {
        if (!GameManager.Instance.IsGameOver)
        {
            int index = Random.Range(0,4);
            GameObject obstacles = Instantiate(objectPrefabs[index], RandomPostion(), objectPrefabs[index].transform.rotation);

            obstacles.transform.parent = holderObject;// giu ostacles trong holder
        }
    }

    // ke thua lop cha SpawnObject de tinh toan vi tri sinh ra 
    public override Vector3 RandomPostion()
    {
        return base.RandomPostion();
    }

    // ke thua lop SpawnObject de tinh random index cua vat the
    public override int RandomIndex()
    {
        return base.RandomIndex();
    }
}
