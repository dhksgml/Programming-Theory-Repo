using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    protected Rigidbody rigidbody;
    protected bool isGround;

    [SerializeField]
    private float jumpForce;
    public float JumpForce
    {
        get { return jumpForce; }
        set { jumpForce = value; }
    }
    [SerializeField]
    private float walkSpeed;
    public float WalkSpeed
    {
        get { return walkSpeed; }
        set { walkSpeed = value; }
    }
    //Encapsulation
    [SerializeField]
    private int age;
    public float Age
    {
        get {return age; } 
        set { age = (int)value; }
    }
    //Encapsulation
    public void Walk()
    {
        rigidbody.AddForce(Vector3.forward * WalkSpeed * Time.deltaTime);
    }

    public virtual void Jump()
    {
        if (isGround)
        {
            rigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            isGround = false;
        }
    }

    public virtual void ChangeAge()
    {

    }

    public virtual void ChangeAge(int age)
    {
        this.age = age;
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGround = true;
    }
}
