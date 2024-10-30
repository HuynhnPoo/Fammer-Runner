using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCharacter : MonoBehaviour
{
    private Animator ani;
    public PlayerJumping playerJump;


    // Start is called before the first frame update
    void Start()
    {
        LoadCompoment();
    }

    void LoadCompoment()
    {
        if (playerJump != null) return;
        playerJump = GameObject.FindObjectOfType<PlayerJumping>().GetComponent<PlayerJumping>();
        ani = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        AnimationJump();
        AnimationDeath();
    }

    // han thuc hien animation jump
    void AnimationJump()
    {
        bool isJump = playerJump.IsCheckGrounded();
        if (!isJump)
        {
            ani.SetTrigger("Jump_trig");
        }
        
    }

    //ham thuc hien animation death
    void AnimationDeath()
    {
        bool isDeath = GameManager.Instance.IsGameOver;

        if (isDeath)
        {
            ani.SetBool("Death_b", GameManager.Instance.IsGameOver);
        }

    }
}