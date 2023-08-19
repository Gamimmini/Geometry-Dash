using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] AgentState stateToChange = AgentState.ground;
    public AgentFlyingMovement isFlying;
    public AgentGravityMovement isGravity;
    public AgentReverseMovement isReverse;
    public AgentSpinMovement isSpin;
    public AgentBirdMovement isBird;
    public AgentTroMovement isTro;
    public AgentTroMovement isZigzag;

  private void  OnTriggerEnter2D(Collider2D collision)
  {
    var controller = collision.attachedRigidbody.GetComponent<AgentController>();
    if (controller == null) return;
    controller.CurrentState = stateToChange; 
      }
  }

