using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public bool placed;
    public float offsetX;

    public static int key = 0;
    public int mainKey = 0;

    Vector2 prevPos;

    // Start is called before the first frame update
    void Start()
    {
        key++;
        mainKey = key;

        transform.position = new Vector2(mainKey - offsetX, 0);
        GetComponent<SpriteRenderer>().color = Random.ColorHSV();

        prevPos = transform.position;

        Debug.Log(key);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(mainKey.ToString()))
        {
            Place();
        }
    }

    void Place()
    {
        if(!placed)
        {
            Inventory.PlaceInInventory(gameObject);
        }
        else
        {
            Inventory.DeleteInventoryObj(gameObject, prevPos);
        }
        Debug.Log("pressed: " + Input.inputString);
        placed = !placed;
    }
}
