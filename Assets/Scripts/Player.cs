using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D rigidbody2D;
    private bool canJump;
    public float speed = 1.5f;
    public float jumpForce = 5f;
    public LayerMask groundLayer;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        rigidbody2D.position += new Vector2(movement * speed * Time.deltaTime, 0);

        if (Input.GetButton("Fire1") && IsGrounded())
        {
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            canJump = false;
        }
    }

    private bool IsGrounded()
    {
        var hit = Physics2D.Raycast(rigidbody2D.position, Vector2.down, 0.8f, groundLayer);
        if (hit.collider != null)
            return true;

        return false;
    }

}
