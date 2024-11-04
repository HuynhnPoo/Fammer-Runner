using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjects : MonoBehaviour
{
    public int speed;
   
    // Update is called once per frame
    void Update()
    {
      
        Moving();
       
    }

    //di chuyen cac doi tuowng
   public void Moving() 
    {
        if (!GameManager.Instance.IsGameOver)
        {
            speed = GameManager.Instance.CurrentSpeed;
            transform.Translate(Vector3.back * speed * Time.deltaTime);

        }
    }
}
