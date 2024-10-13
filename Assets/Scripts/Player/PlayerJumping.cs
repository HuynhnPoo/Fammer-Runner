using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumping : MonoBehaviour
{

    [SerializeField] private float gravityModifier =2.5f;
    [SerializeField] private float jumpHeight = 5;
    [SerializeField] private LayerMask maskGround;
    private Rigidbody rbPlayer;

    [SerializeField] private Transform groundCheck;
    // Start is called before the first frame update
    void Start()
    {
         LoadComponment();
    }

    void LoadComponment()
    {
        Physics.gravity *= gravityModifier;
        rbPlayer = GetComponent<Rigidbody>();
        groundCheck = GameObject.Find("Check_Ground").GetComponent<Transform>();
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        Jumping();
    }
    public void Jumping()
    {
        if (Input.GetButton("Jump")&& IsCheckGrounded())
        {
            rbPlayer.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }

    }

    public bool IsCheckGrounded()
    {
        float radius = 0.5f;
        return Physics.CheckSphere(groundCheck.position, radius, maskGround);
    }
}
