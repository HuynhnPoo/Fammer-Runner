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
    public abstract Vector3 RandomPostion();
    public abstract int RandomIndex();
}