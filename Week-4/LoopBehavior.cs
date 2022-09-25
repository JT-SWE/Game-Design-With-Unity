using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBehavior : MonoBehaviour
{

    [SerializeField] GameObject _itemToClone;
    
    void Start()
    {
        int itemsToSpawn = 5;
        while (itemsToSpawn != 0)
        {
            cloneItem();
            itemsToSpawn--;
        }

        /*
         Do While Example, express use cases for this loop.

        do{
            cloneItem();
            itemsToSpawn--;
         }

        while (itemCount > 0);
         */
        /*
         
        */
    }

    void cloneItem()
    {
        // Range values bases on the height and width of the current camera view.
        Instantiate(_itemToClone, new Vector2(Random.Range(6.5f, -6.5f), Random.Range(3.5f, -3.5f)), Quaternion.identity);
    }
   
}
