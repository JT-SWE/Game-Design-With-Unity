using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D playerRb;
    float moveSpeed;

    float moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody2D>();
        moveSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = Input.GetAxisRaw("Horizontal");

        if(moveDirection != 0)
        {
            playerRb.AddForce(new Vector2(moveDirection * moveSpeed, 0f));
        }
    }
}
