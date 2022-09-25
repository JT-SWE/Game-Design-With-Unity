using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] collectableBehavior _collectableBehavior;
    //[SerializeField] scoreLog scoreLog;
    

    void Start()
    {
        _collectableBehavior.createCollectable();

    }

}
