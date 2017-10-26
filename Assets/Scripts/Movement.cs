using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;
    public float rotationSpeed;

    float horizontal;
    float vertical;


    void Move()
    {
        horizontal = Input.GetAxis("Horizontal") * rotationSpeed;
        vertical = Input.GetAxis("Vertical") * speed;


        horizontal *= Time.deltaTime;
        vertical *= Time.deltaTime;

        transform.Translate(horizontal, 0, vertical);
    }


    // Use this for initialization
    void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();
    }
}
