using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // getting input from usr
        float h = Input.GetAxis("Horizontal");   // A, D, Right arrow and Left arrow 
        float v = Input.GetAxis("Vertical");   // W, S, Up arrow and Down arrow

        Vector2 pos = transform.position; // position of the gameInput

        pos.x += h * speed * Time.deltaTime;
        pos.y += v * speed * Time.deltaTime;
        transform.position = pos;
    }

}
