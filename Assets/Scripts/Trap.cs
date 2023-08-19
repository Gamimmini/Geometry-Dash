using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    Rigidbody2D rb;
   [SerializeField] float rotateVelocity = 6f;

    private void Awake()
 {
    rb = GetComponentInParent<Rigidbody2D>();
 }
     private void FixedUpdate()
     {
        rb.angularVelocity = - rotateVelocity * Mathf.Rad2Deg;
     }
}
