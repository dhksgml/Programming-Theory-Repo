using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal  //inheritance
{
    private void Start()
    {
        Age = 3;
        WalkSpeed = 1500;
        JumpForce = 8;

        rigidbody = GetComponent<Rigidbody>();
    }
}
