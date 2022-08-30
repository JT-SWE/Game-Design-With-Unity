using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*
     Propertity Scope: Private
     Propertity Data Type String
     */
    private string _characterName;
    /*
     Propertity Scope: Private
     Propertity Data Type Bool
    */
    private bool _isMoving;
    /*
    Propertity Scope: Private
    Propertity Data Type float
    */
    private float _movementSpeed;
    /*
    Propertity Scope: Private
    Propertity Data Type int
    */
    private int _characterHealth;
    /*
    Propertity Scope: Private
    Propertity Data Type Vector2
    */
    private Vector2 _characterPosition = new Vector2(0f, 0f);
    /*
      Accessing Field Component [RigidBody2D]

    */
    private Rigidbody2D squareRb;

    void Start()
    {
        /*
            Grab Rigid body and modify components
        */
        squareRb = gameObject.GetComponent<Rigidbody2D>();
        squareRb.gravityScale = 1;
    }


    void Update()
    {
        
    }
}
