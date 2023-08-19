using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AgentGroundMovement : MonoBehaviour
{
 [SerializeField] float movementSpeed = 2f;
 [SerializeField] float jumpStrength = 5f;

 [SerializeField] float jumpStrengthGround = 2f;
 [SerializeField] float onGroundDistance = 1f;
 [SerializeField] float jumpPointDistance = 1f;
 [SerializeField] float rotateVelocity = 6f;
 private bool isJumping;
 public bool IsJumping { 
  get
  {
    return isJumping;
  }
  set
  { 
    if (isJumping == value) return;
    isJumping = value;

    if(isJumping)
    {
      if (NearJumpPoint()) Jump();
    }
  }
}
 Rigidbody2D rb;

 
 private void Awake()
 {
    rb = GetComponentInParent<Rigidbody2D>();
 }

 private void FixedUpdate()
 {
    rb.velocity = new Vector2(movementSpeed, rb.velocity.y);
    rb.gravityScale = 7;
    if(!OnGrounded())
    {
      rb.angularVelocity = - rotateVelocity * Mathf.Rad2Deg;
    }

    if (IsJumping)
      JumpBehaviour();
    if(PointGround())
          rb.AddForce(Vector2.up * jumpStrengthGround, ForceMode2D.Impulse);  
 }

 public void JumpBehaviour()
 {
   if(OnGrounded()) Jump();    
 }
 public void Jump()
 {
  rb.velocity = new Vector2(rb.velocity.x, jumpStrength);
 }
 public bool OnGrounded()
 {
   var hit = Physics2D.Raycast(transform.position, Vector2.down, onGroundDistance, 1 << LayerMask.NameToLayer("Platform"));
   return hit.collider != null;
 }
 public bool NearJumpPoint()
 {
   var hit = Physics2D.CircleCast(transform.position, jumpPointDistance, Vector2.zero, 0, 1 << LayerMask.NameToLayer("JumpPoint"));
   return hit.collider != null;
 }
 public bool PointGround()
 {
   var hit = Physics2D.CircleCast(transform.position, jumpPointDistance, Vector2.zero, 0, 1 << LayerMask.NameToLayer("PointGround"));
   return hit.collider != null;
 }
 
}

