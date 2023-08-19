using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentReverseMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10f;
 [SerializeField] float flyingStrength = 1f;
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
        rb.AddForce(Vector2.down * flyingStrength, ForceMode2D.Impulse);         
        transform.right = rb.velocity;
        rb.gravityScale = -4;
    }
}
