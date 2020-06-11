using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodList : MonoBehaviour
{
    private void Start()
    {
        //Runs when you first even a world
    }

    private void Update()
    {
        //Runs every frame
    }

    private void OnEnable()
    {
        //when the object that is attached to the script turns on
    }
    private void OnDisable()
    {
        //when the object that is attached to the script turns off
    }


    //Trigger colliders
    private void OnTriggerEnter(Collider hit)
    {
        //HAS TO BE ATTACHED TO AN OBJECT WITH A TRIGGER COLLIDER
        //when a rigidbody enter the trigger
    }
    private void OnTriggerExit(Collider hit)
    {
        //HAS TO BE ATTACHED TO AN OBJECT WITH A TRIGGER COLLIDER
        //when a rigidbody leaves the trigger
    }
    private void OnTriggerStay(Collider hit)
    {
        //HAS TO BE ATTACHED TO AN OBJECT WITH A TRIGGER COLLIDER
        //every frame that a rigidbody is in the trigger
    }


    //Normal Colliders
    private void OnCollisionEnter(Collision hit)
    {
        //HAS TO BE ATTACHED TO AN OBJECT WITH A COLLIDER
        //when a rigidbody hits the collider
    }
    private void OnCollisionExit(Collision hit)
    {
        //HAS TO BE ATTACHED TO AN OBJECT WITH A COLLIDER
        //when a rigidbody stops hitting the collider
    }
    private void OnCollisionStay(Collision hit)
    {
        //HAS TO BE ATTACHED TO AN OBJECT WITH A COLLIDER
        //every frame that a rigidbody is activly colliding with the collider
    }
}
