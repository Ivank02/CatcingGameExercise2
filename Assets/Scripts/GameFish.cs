using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;
using UnityEngine.UI;

public class GameFish : MonoBehaviour
{
    // Initialize required variables
    public GameObject fish;
    public net netObj;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        // Create new fish object once in every 0.8 seconds
        InvokeRepeating("createFish", 1, 0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        // Change score count text with each fish caught in net
        score.text = netObj.score.ToString();
    }

    // Create fish object in background border range (randomly)
    void createFish()
    {
        float fishPosition = Random.Range(-3.5f, 4.5f);
        Instantiate(fish, new Vector3(fishPosition, 5.5f, 0f), new Quaternion(0, 0, 0, 0));
    }
}