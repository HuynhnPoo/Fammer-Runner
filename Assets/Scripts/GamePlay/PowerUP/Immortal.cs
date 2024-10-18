using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Immortal : MonoBehaviour, IPowerUp
{

    private Rigidbody playerRb;
    private BoxCollider playerBoxCollider;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerBoxCollider = GetComponent<BoxCollider>();
        
    }

    // hàm thuc hien ImmortalActive
    public void ActivePowerUp()
    {
        StartCoroutine(ImmortalActive());
        Debug.Log(gameObject.name);
    }

    public IEnumerator ImmortalActive ()
    {
        // bắt đầu thực hiện immortal
        playerBoxCollider.isTrigger = true;
        playerRb.isKinematic = true;
        

        yield return new WaitForSeconds(3);
        
        // sau 5 giay sẽ tắt immotal
        playerRb.isKinematic = false;
        playerBoxCollider.isTrigger = false;
    }

}
