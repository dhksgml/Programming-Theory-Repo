using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private GameObject catObject;
    [SerializeField]
    private GameObject dogObject;
    [SerializeField]
    private GameObject chickenObject;

    private Cat cat;
    private Dog dog;
    private Chicken chicken;

    void Start()
    {
        cat = catObject.GetComponent<Cat>();
        dog = dogObject.GetComponent<Dog>();
        chicken = chickenObject.GetComponent<Chicken>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            cat.Walk();
        }

        if (Input.GetKey(KeyCode.W))
        {
            chicken.Walk();
        }

        if (Input.GetKey(KeyCode.E))
        {
            dog.Walk();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            cat.Jump();
            chicken.Jump();
            dog.Jump();
        }

        if(Input.GetKeyDown(KeyCode.R))
        { 
            cat.ChangeAge(15);
            dog.ChangeAge(10);
            chicken.ChangeAge(5);
        }
    }
}
