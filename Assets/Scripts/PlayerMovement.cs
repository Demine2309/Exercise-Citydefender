using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float _moveSpeed = 5;

    private Rigidbody2D _rb;
    float horizontalInput = Input.GetAxisRaw("Horizontal");


    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
    }

    private void FixedUpdate()
    {

        Vector3 moveInput = new Vector3(horizontalInput, 0, 0);
    }
}
