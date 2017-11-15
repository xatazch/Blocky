using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D rigidbody2D;
    public float speed = 1.5f;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        rigidbody2D.position += new Vector2(movement * speed * Time.deltaTime, 0);
    }

}
