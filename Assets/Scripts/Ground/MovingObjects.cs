using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjects : MonoBehaviour
{
    private int speed = 10;
    // Start is called before the first frame update
    void Start()
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
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
}
