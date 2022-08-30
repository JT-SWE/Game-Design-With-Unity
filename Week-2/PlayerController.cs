using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*
     Field Scope: Private
     Field Data Type String
     */
    private string _characterName;
    /*
     Field Scope: Private
     Field Data Type Bool
    */
    private bool _isMoving;
    /*
    Field Scope: Private
    Field Data Type float
    */
    private float _movementSpeed;
    /*
    Field Scope: Private
    Field Data Type int
    */
    private int _characterHealth;
    /*
    Field Scope: Private
    Field Data Type Vector2
    */
    private Vector2 _characterPosition = new Vector2(0f, 0f);
    /*
      Accessing Field Component [RigidBody2D]

    */
    private Rigidbody2D squareRb;

    void Start()
    {
        /*
            Grab Rigid body and modify component
        */
        squareRb = gameObject.GetComponent<Rigidbody2D>();
        squareRb.gravityScale = 1;
    }


    void Update()
    {
        
    }
}
