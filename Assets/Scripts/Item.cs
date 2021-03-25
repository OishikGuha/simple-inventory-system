using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public bool placed;

    Vector2 prevPos;

    // Start is called before the first frame update
    void Start()
    {
        prevPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if(!placed)
        {
            Inventory.PlaceInInventory(gameObject);
        }
        else
        {
            Inventory.DeleteInventoryObj(gameObject, prevPos);
        }
        placed = !placed;
    }
}
