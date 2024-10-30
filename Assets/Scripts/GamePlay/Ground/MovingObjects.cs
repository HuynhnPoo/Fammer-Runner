using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjects : MonoBehaviour
{
    public int speed;
    private void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
      
        Moving();
       
    }

   public void Moving() 
    {
        if (!GameManager.Instance.IsGameOver)
        {
            speed = GameManager.Instance.CurrentSpeed;
            transform.Translate(Vector3.back * speed * Time.deltaTime);

        }
    }
}
