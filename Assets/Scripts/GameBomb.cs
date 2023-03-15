using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameBomb : MonoBehaviour
{
    // Initialize game object "bomb"
    public GameObject bomb;

    // Start is called before the first frame update
    void Start()
    {
        // Create new bomb object once in every 1.5 seconds
        InvokeRepeating("createBomb", 1, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {   
    }

    // Create bomb object in background border range (randomly)
    void createBomb()
    {
        float bombPosition = Random.Range(-3.5f, 4f);
        Instantiate(bomb, new Vector3(bombPosition, 5.5f, 0f), new Quaternion(0, 0, 0, 0));
    }
}