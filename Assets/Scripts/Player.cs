using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D playerRigidbody2D;
    public float speed = 1.5f;
    public float jumpForce = 5f;
    public LayerMask groundLayer;

    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        playerRigidbody2D.position += new Vector2(movement * speed * Time.deltaTime, 0);

        if (Input.GetButton("Fire1") && IsGrounded())
        {
            playerRigidbody2D.velocity = Vector2.zero;
            playerRigidbody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }

    private bool IsGrounded()
    {
        var hit = Physics2D.Raycast(playerRigidbody2D.position, Vector2.down, 0.8f, groundLayer);
        if (hit.collider != null)
            return true;

        return false;
    }

}
