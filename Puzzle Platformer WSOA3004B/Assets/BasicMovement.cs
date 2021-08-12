using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float MoveSpeed; // Movespeed of the player
    public float JumpForce; // How high player can jump
    private float MoveInput; //Getting movement direction
    private bool IsGrounded; //For later when character controller is completely fleshed out
    public Rigidbody2D PlayerBody;

    void Start()
    {
        PlayerBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MoveInput = Input.GetAxis("Horizontal");
        PlayerBody.velocity = new Vector2(MoveInput*MoveSpeed, PlayerBody.velocity.y);

        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    //Basic Jump function 
    public void Jump()
    {
        PlayerBody.velocity = Vector2.up * JumpForce;
    }
}
