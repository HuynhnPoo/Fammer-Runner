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
    public void ActivePowerUp()
    {
        StartCoroutine(ImmortalActive());
    }

    public IEnumerator ImmortalActive ()
    {
        playerBoxCollider.isTrigger = true;
        playerRb.isKinematic = true;
        Debug.Log(" hir thi ");

        yield return new WaitForSeconds(3);
        Debug.Log(" hir thi wefwefwe");

        playerRb.isKinematic = false;
        playerBoxCollider.isTrigger = false;
    }

}
