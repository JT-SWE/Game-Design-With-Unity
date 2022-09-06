using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableBehavior : MonoBehaviour
{
    [SerializeField] GameObject _prefabCollectable;
    bool _isGameOver = false;

    public void createCollectable() {

        Instantiate(_prefabCollectable, new Vector3(Random.Range(-8f,8f), 13f, 0f), Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !_isGameOver)
        {
            createCollectable();
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            _isGameOver = true;
            Debug.Log("GAME OVER .. DON'T LET THE SQUARES REACH THE GROUND !");
        }
    }
}
