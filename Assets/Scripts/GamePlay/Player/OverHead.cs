using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverHead : MonoBehaviour
{
    private Vector3 playerScale;
    private float croundHeight = 0.7f;
    private float verhical;
    // Start is called before the first frame update
    void Start()
    {
        playerScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Siting();
    }

    public void Siting()
    {
        verhical = Input.GetAxisRaw("Vertical");
        if (verhical < 0)
        {
            if (transform.localScale.y != croundHeight)
                transform.localScale = new Vector3(playerScale.x, croundHeight, playerScale.z);
        }
        else
        {
            if (transform.localScale.y != playerScale.y)
                transform.localScale = playerScale;
        }
    }
}
