using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacles : MonoBehaviour
{

    // Update is called once per framek
    void Update()
    {
        Destroy();// thuc hien ham
    }

    // kiem tra vi tri va xoa vat the
    private void Destroy()
    {
        
        if (this.transform.position.z<-20) 
        {
            Destroy(gameObject);
        }
    }
}
