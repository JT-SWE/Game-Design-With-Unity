using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     /*
     Fields Part 1
     */

    private string _characterName;

    private bool _isMoving;

    private float _movementSpeed;

    private int _characterHealth = 100;

    private int _newHealth;

    private Vector2 _characterPosition = new Vector2(0f, 0f);

    private Rigidbody2D squareRb;

    /*
    Properties Part 2
    */

    public int CharacterHealth
    {
        get
        {
            return _characterHealth;
        }
        set
        { 
            _characterHealth = value;
            
        }
    }

    public string DisplayCurrentHealth
    {
        get
        {
            string currentHealth = _characterHealth.ToString() + "%";
            return currentHealth;
        }

    }

    /*
    Methods Part 3
    */


    void Start()
    {
       
        squareRb = gameObject.GetComponent<Rigidbody2D>();
        squareRb.gravityScale = 0;
        
        Debug.Log("Player has " + DisplayCurrentHealth + " Health.");

        Debug.Log("You picked up a small potion. Health: " + HealthPotion());

        Debug.Log("You picked up a choose your own healing potion. Health: " + CustomHeal(45));
    }

    int HealthPotion() {
        return CharacterHealth += 25;
    }

    int CustomHeal(int healAmount) {
        int newHealth = CharacterHealth + healAmount;
        return newHealth;
    }


    void Update()
    {

    }
}
