using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedPlayerController : MonoBehaviour
{
    Rigidbody2D playerRb;

    private float _playerMovementSpeed = 10f;

    float _horizontalDirection;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalDirection = Input.GetAxisRaw("Horizontal");

        if (_horizontalDirection != 0)
        {
            playerRb.AddForce(new Vector2(_horizontalDirection * _playerMovementSpeed, 0));
        }
    }
}
