using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentBirdMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 15f;
    [SerializeField] float speed = 15f;
    [SerializeField] KeyCode jumpKey = KeyCode.Space;
    
    Rigidbody2D rb;
  private void Awake()
  {
    rb = GetComponentInParent<Rigidbody2D>();
  }
   private void Update()
  {
    rb.velocity = new Vector2(movementSpeed, rb.velocity.y); 
    rb.gravityScale = 4;
   if (Input.GetKeyDown(jumpKey) || Input.GetMouseButtonDown(0))
   
    rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);   
  }
}
