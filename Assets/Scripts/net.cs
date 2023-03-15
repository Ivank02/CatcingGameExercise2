using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class net : MonoBehaviour
{
    // Initialize required variables
    public int speed;
    public int score = 0;
    public Text endText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Check for user input keys
        // Left & Right arrow key
        if(Input.GetKey(KeyCode.RightArrow))
        {
            // Moves net right
            transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Moves net left
            transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }
        else
        {
            // Else stay in place
            transform.Translate(new Vector3(0, 0, 0) * speed * Time.deltaTime);
        }

        // Move net x coordinate
        // set bounds to background width
        float xPosition = transform.position.x;
        xPosition = Mathf.Clamp(xPosition, -3.5f, 5.2f);
        transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);
    }

    // Collision detection
    private void OnTriggerEnter2D(Collider2D c)
    {
        // If net collides with a fish object
        if (c.gameObject.name == "fish(Clone)")
        {
            // increment score
            score += 1;
            // destroy fish
            Destroy(c.gameObject);
        }
        // If net collides with a bomb object
        if (c.gameObject.name == "bomb(Clone)")
        {
            // Output game over text
            endText.text = "GAME OVER";
            Destroy(c.gameObject);
            // in 0.5 seconds quit
            Invoke("endGame", 0.5f);
        }
    }

    // End game and editor
    void endGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}