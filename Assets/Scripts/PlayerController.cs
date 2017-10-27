using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;    

    float horizontal;
    float vertical;

    void Move()
    {   
        // Keyboard transform of player
        horizontal = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime; ;      
        
        transform.Translate(horizontal, 0, vertical);

        // Mouse rotate of player
        float mouseX = Input.GetAxis("Mouse X");

        transform.Rotate(0, mouseX, 0);
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
