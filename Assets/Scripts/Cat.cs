using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal  //inheritance
{
    //private bool isGround;
    private void Start()
    {
        Age = 1;
        WalkSpeed = 1000;
        JumpForce = 5;

        rigidbody = GetComponent<Rigidbody>();
    }
}
