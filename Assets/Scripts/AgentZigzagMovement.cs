using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentZigzagMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 7f;
    [SerializeField] float flyingStrength = 2f;

    Rigidbody2D rb;
    private bool isFlyingUp = true;

    private void Awake()
    {
        rb = GetComponentInParent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = new Vector2(movementSpeed, rb.velocity.y);

        if (isFlyingUp)
        {
            rb.AddForce(Vector2.up * flyingStrength, ForceMode2D.Impulse);
           
        }
        else
        {
            rb.AddForce(Vector2.down * flyingStrength, ForceMode2D.Impulse);
           
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isFlyingUp = !isFlyingUp;
        }
    }
}