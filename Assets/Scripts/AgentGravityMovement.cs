using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentGravityMovement : MonoBehaviour
{
  [SerializeField] float movementSpeed = 2f;
 [SerializeField] float jumpStrength = 5f;

 [SerializeField] float jumpStrengthGround = 4f;
 [SerializeField] float onGroundDistance = 1f;
 [SerializeField] float jumpPointDistance = 1f;
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
      if (NearJumpPoint2()) Down();
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
    rb.gravityScale = -7;

    if (IsJumping)
      GravityBehaviour();
    if(PointGround2())
          rb.AddForce(Vector2.down * jumpStrengthGround, ForceMode2D.Impulse);  
 }

 public void GravityBehaviour()
 {
   if(OnGrounded2()) Down();    
 }
 public void Down()
 {
  rb.AddForce(Vector2.down * jumpStrength, ForceMode2D.Impulse);
 }
  public bool OnGrounded2()
 {
   var hit = Physics2D.Raycast(transform.position, Vector2.up, onGroundDistance, 1 << LayerMask.NameToLayer("PlatformOn"));
   return hit.collider != null;
 }
 public bool NearJumpPoint()
 {
   var hit = Physics2D.CircleCast(transform.position, jumpPointDistance, Vector2.zero, 0, 1 << LayerMask.NameToLayer("JumpPoint"));
   return hit.collider != null;
 }
 public bool NearJumpPoint2()
 {
   var hit = Physics2D.CircleCast(transform.position, jumpPointDistance, Vector2.zero, 0, 1 << LayerMask.NameToLayer("JumpPointdown"));
   return hit.collider != null;
 }
 public bool PointGround()
 {
   var hit = Physics2D.CircleCast(transform.position, jumpPointDistance, Vector2.zero, 0, 1 << LayerMask.NameToLayer("PointGround"));
   return hit.collider != null;
 }
 public bool PointGround2()
 {
   var hit = Physics2D.CircleCast(transform.position, jumpPointDistance, Vector2.zero, 0, 1 << LayerMask.NameToLayer("PointGround2"));
   return hit.collider != null;
 }
 
}
