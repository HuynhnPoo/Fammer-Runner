using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolToPrefabs : MonoBehaviour
{
    private int size = 5;

  [SerializeField] private GameObject objectPrefabs;

   [SerializeField] private Queue<GameObject> queue = new Queue<GameObject>();


    private Transform holderBullets;

    private void OnEnable()
    {
        holderBullets =GameObject.Find("BulletBoss").GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        InitiaLizePool();
    }

    // khoi tao pool
    void InitiaLizePool() 
    {

        
        for (int i =0; i<size; i++) 
        {
            GameObject obj=Instantiate(objectPrefabs);  
            obj.SetActive(false);
            queue.Enqueue(obj); 


            obj.transform.parent = holderBullets;
        }
    }


    public GameObject GetOjectPool()
    {
        if (queue.Count <= 0)
        {
            GameObject obj = Instantiate(objectPrefabs);
            obj.SetActive(false);
            queue.Enqueue(obj);
            return obj;
        }
        else
        { 
            GameObject obj = queue.Dequeue();
            obj.SetActive(true);
            return obj;
        }
    }

    public void ReturnObjectPool(GameObject obj)
    {
        obj.SetActive(false);
        queue.Enqueue(obj);
    }
}
