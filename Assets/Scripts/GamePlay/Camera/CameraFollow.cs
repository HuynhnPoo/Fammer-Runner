using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform trfPlayer;

    private Vector3 offset=new Vector3(0,4,-4);
    // Start is called before the first frame update
    void Start()
    {
        LoadTransform();//thuc hien ham tim transform cua game objectPlayer
        FollowToPlayer();

        transform.rotation = Quaternion.Euler(20f,0,0);   
    }

    //tim transform cua game objectPlayer
    void LoadTransform() 
    {
        trfPlayer = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        FollowToPlayer();// cap nhat vi tri plyer
    }
   
    // ham di theo player
    void FollowToPlayer() 
    {
       this.transform.position = trfPlayer.position + offset;
    }
}
