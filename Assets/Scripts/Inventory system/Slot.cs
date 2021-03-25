using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{

    public bool occupied = false;
    public GameObject occupingObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        occupied = true;
        occupingObj = other.gameObject;    
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        occupied = false;
        occupingObj = null;
    }
}
