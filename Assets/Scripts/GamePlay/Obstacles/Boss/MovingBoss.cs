using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBoss : MonoBehaviour
{
    private float speed = 6;
    private bool moveRight = true;

    private void FixedUpdate()
    {
        Move();
        CheckPosX();    
    }


    //ham di chuyen 
    public void Move()
    {
        if (moveRight) transform.position += Vector3.right * speed * Time.deltaTime;
        else transform.position -= Vector3.right * speed * Time.deltaTime;

    }


    // kiem tra vi tri x cua boss
    public void CheckPosX()
    {
        if (transform.position.x > 6) moveRight = false;
        else if (transform.position.x < -6) moveRight = true;
    }
}
