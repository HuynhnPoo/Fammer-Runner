using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumping : MonoBehaviour
{

    [SerializeField] private float gravityModifier =2.5f;
    [SerializeField] private float jumpHeight = 5;
    [SerializeField] private LayerMask maskGround;
    
    
    private Transform groundCheck;
     private MuiscControll music;
    private Rigidbody rbPlayer;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    private void OnEnable()
    {
        LoadComponment();
    }

    void LoadComponment()
    {

        if (rbPlayer != null && groundCheck != null && music != null) return;

        Physics.gravity *= gravityModifier;
        rbPlayer = GetComponent<Rigidbody>();
        groundCheck = GameObject.Find("Check_Ground").GetComponent<Transform>();
        music =GameObject.FindGameObjectWithTag(TagInGame.MainCameraTag).GetComponent<MuiscControll>();
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        Jumping();
    }
    public void Jumping()
    {
        if (Input.GetButton("Jump") && IsCheckGrounded())
        {
            music.PlayJumpAClip(); 
           
            rbPlayer.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
           
        }

    }

    public bool IsCheckGrounded()
    {
        float radius = 0.5f;
        return Physics.CheckSphere(groundCheck.position, radius, maskGround);
    }
}
