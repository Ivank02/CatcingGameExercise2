using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {   
    }

    // Collision
    private void OnTriggerEnter2D(Collider2D c)
    {
        // If fish or bomb
        // collide with floor
        // destroy object
        if (c.gameObject.name == "fish(Clone)")
        {
            Destroy(c.gameObject);
        }
        if (c.gameObject.name == "bomb(Clone)")
        {
            Destroy(c.gameObject);
        }
    }
}