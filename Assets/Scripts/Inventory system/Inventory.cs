using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public List<Slot> slots;
    public static List<Slot> SLOTS;


    // Start is called before the first frame update
    void Start()
    {
        SLOTS = slots;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaceInInventory(GameObject obj)
    {
        for (int i = 0; i < SLOTS.Count; i++)
        {
            if(!SLOTS[i].occupied)
            {
                obj.transform.position = SLOTS[i].transform.position;
            }
        }
    }

    public static void DeleteInventoryObj(GameObject obj, Vector2 pos)
    {
        if(obj.GetComponent<Item>().placed)
        {
            obj.transform.position = pos;
        }
    }
}
