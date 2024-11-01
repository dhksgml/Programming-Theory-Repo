using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal  //inheritance
{
    private void Start()
    {
        Age = 4;
        WalkSpeed = 1000;
        JumpForce = 5;

        rigidbody = GetComponent<Rigidbody>();
    }
    public override void Jump()      //polymorphism
    {
        if (isGround)
        {
            rigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            isGround = false;
        }
    }
    private void Update()
    {
        FallSlowly();   //abstraction
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGround = true;
        rigidbody.drag = 0;
    }

    private void FallSlowly()
    {
        if (rigidbody.velocity.y >= 0) rigidbody.drag = 0;
        else rigidbody.drag = 10;
    }
}
