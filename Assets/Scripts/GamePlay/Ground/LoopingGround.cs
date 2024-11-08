using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingGround : MonoBehaviour
{
    private Vector3 startPos;
    private int repeatWidth = 40;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;// gan startPos cho vi tri background
    }

    // Update is called once per frame
    void Update()
    {
        Looping();// thuc hien ham looping
    }


    // kiem tra position Z va looping
    void Looping()
    {
        if (transform.position.z < startPos.z - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
