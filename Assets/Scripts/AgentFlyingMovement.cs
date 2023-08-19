using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentFlyingMovement : MonoBehaviour
{
 // private float dirX = 0f;
  [SerializeField] float movementSpeed = 15f;
  [SerializeField] float flyingStrength = 2f;
  public bool IsFlying { get; set; }
  
  Rigidbody2D rb;
    private void Awake()
    {
      rb = GetComponentInParent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
      rb.velocity = new Vector2(movementSpeed, rb.velocity.y);
      Debug.Log(rb.velocity);
        if(IsFlying)
          rb.AddForce(Vector2.up * flyingStrength, ForceMode2D.Impulse);         
          transform.right = rb.velocity;
          rb.gravityScale = 5;
      }
  }


