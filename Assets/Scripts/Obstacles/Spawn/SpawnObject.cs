using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnObject : MonoBehaviour
{
    [SerializeField] protected int minValueX = -10;
    [SerializeField] protected int spaceBetween = 10;

    [SerializeField] protected GameObject[] objectPrefabs;
    [SerializeField] protected Transform holderObject;

    protected float timeStartSpawn;
    protected float timeRepeatRate;

    public abstract void Spawn();

    // tinh toan vi tri sinh ra 
    public virtual Vector3 RandomPostion()
    {
        float spawnPosX = minValueX + (RandomIndex() * spaceBetween);

        return new Vector3(spawnPosX, this.transform.position.y, this.transform.position.z);
    }

    // random index cua vat the
    public virtual int RandomIndex()
    {
        return Random.Range(0, 2);
    }
}