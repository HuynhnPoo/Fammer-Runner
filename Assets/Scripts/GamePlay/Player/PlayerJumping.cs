using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumping : MonoBehaviour
{

    [SerializeField] private float gravityModifier = -9.8f;
    [SerializeField] private float jumpHeight = 3;
    [SerializeField] private LayerMask maskGround;


    private Transform groundCheck;
    private MusicControl music;
    private Rigidbody rbPlayer;



    // Start is called before the first frame update
    private void OnEnable()
    {
        LoadComponment();
    }

    void LoadComponment()
    {
        if (rbPlayer != null && groundCheck != null && music != null) return;


        rbPlayer = GetComponent<Rigidbody>();
        groundCheck = GameObject.Find("Check_Ground").GetComponent<Transform>();
        music = GameObject.FindGameObjectWithTag(TagInGame.MainCameraTag).GetComponent<MusicControl>();
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        Jumping();
    }

    // ham lafm cho nhan vat nhay
    public void Jumping()
    {
        if (Input.GetButton("Jump") && IsCheckGrounded())
        {

            rbPlayer.velocity = Vector3.up * Mathf.Sqrt(jumpHeight * -2 * gravityModifier);
            // rbPlayer.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            music.PlayJumpAClip();

        }

        else if (rbPlayer.velocity.y < -1 && IsCheckGrounded()) { rbPlayer.velocity = Vector3.zero; }
        rbPlayer.velocity +=Vector3.up * gravityModifier *3 * Time.deltaTime ;
    }

    //ham kiem tra nhan vat co o tren ground hay khong
    public bool IsCheckGrounded()
    {
        float radius = 0.5f;
        return Physics.CheckSphere(groundCheck.position, radius, maskGround);
    }
}
