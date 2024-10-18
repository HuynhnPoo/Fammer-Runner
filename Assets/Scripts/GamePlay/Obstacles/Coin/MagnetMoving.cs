using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetMoving : MonoBehaviour
{

    public Transform target;
    private int speed = 20;
    

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(target);
        MoveToPlayer();
    }

    public void MoveToPlayer()
    {
        if (target)// kiem tra neu co target thi thuc hien tinh toan va di chuyen den player
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
