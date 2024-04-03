using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb;

    public float _moveSpeed = 5;
    float horizontalInput = 0f;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(horizontalInput, 0).normalized;

        _rb.velocity = direction * _moveSpeed;
    }
}
