using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Immortal : MonoBehaviour
{

    private Rigidbody playerRb;
    private BoxCollider playerBoxCollider;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerBoxCollider = GetComponent<BoxCollider>();
    }

    IEnumerator Immortalimplement()
    {
        playerBoxCollider.isTrigger = true; 
        playerRb.isKinematic = true;
        yield return new WaitForSeconds(3);
        playerRb.isKinematic = false;
        playerBoxCollider.isTrigger=false;
    }
}
