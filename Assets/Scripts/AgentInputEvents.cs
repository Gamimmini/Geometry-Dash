using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class AgentInputEvents : MonoBehaviour
{
    [SerializeField] KeyCode jumpKey = KeyCode.Space;

    public UnityEvent OnJumpKeyPressed;
    public UnityEvent OnJumpKeyReleased;
   
    private void Update()
    {
        if (Input.GetKeyDown(jumpKey) || Input.GetMouseButtonDown(0))
        OnJumpKeyPressed?.Invoke();
        if (Input.GetKeyUp(jumpKey) || Input.GetMouseButtonUp(0))
        OnJumpKeyReleased?.Invoke();
    }
}
