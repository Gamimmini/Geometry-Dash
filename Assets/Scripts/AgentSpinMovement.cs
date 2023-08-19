using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentSpinMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10f;

 [SerializeField] float jumpStrengthGround = 3f;
 [SerializeField] float onGroundDistance = 2f;
 [SerializeField] float jumpPointDistance = 1f;
 //[SerializeField] float rotateVelocity = 3f;
public bool IsChange { get; set; }
 Rigidbody2D rb;

 
 private void Awake()
 {
    rb = GetComponentInParent<Rigidbody2D>();
 }

 private void Update()
 {
    rb.velocity = new Vector2(movementSpeed, rb.velocity.y); 
    //rb.angularVelocity = - rotateVelocity * Mathf.Rad2Deg;
   if (Input.GetKeyDown("space") || Input.touchCount > 0)
      ChangeBehaviour();
    if(PointGround() || NearJumpPoint() )
          rb.AddForce(Vector2.up * jumpStrengthGround, ForceMode2D.Impulse);  
          else if(PointGround2() || NearJumpPoint2())
          rb.AddForce(Vector2.down * jumpStrengthGround, ForceMode2D.Impulse);
    
 }

 public void ChangeBehaviour()
 {
     if(OnGrounded()) 
        up();
    else if (OnGrounded2())
    {
        down();
    }
 }
  public void up()
 {
  rb.gravityScale = -10;
 }
 public void down()
 {
  rb.gravityScale = 10;
 }

 public bool OnGrounded()
 {
   var hit = Physics2D.Raycast(transform.position, Vector2.down, onGroundDistance, 1 << LayerMask.NameToLayer("Platform"));
   return hit.collider != null;
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
   var hit = Physics2D.CircleCast(transform.position, jumpPointDistance, Vector2.zero, 0, 1 << LayerMask.NameToLayer("JumpPoint2"));
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
//private void OnDrawGizmosSelected()
//{
   // Gizmos.DrawRay(transform.position,Vector2.down * onGroundDistance);
//}
}
