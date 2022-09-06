using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] collectableBehavior _collectableBehavior;


    void Start()
    {
        _collectableBehavior.createCollectable();

    }


    void Update()
    {
        
    }
}
