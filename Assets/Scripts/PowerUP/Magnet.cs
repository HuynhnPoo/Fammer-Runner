using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        MagnetMoving coinMoving= other.GetComponent<MagnetMoving>();

        if (coinMoving != null)
        {
            coinMoving.target = transform;
        }
    }


}
