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

        Debug.Log(target);
        if (target)
        {
            Vector3 direction = ( target.position - transform.position ).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
