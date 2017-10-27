
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;
    public float rotationSpeed;

    float horizontal;
    float vertical;


    void Move()
    {
        float mouseX = Input.GetAxis("Mouse X");

        horizontal = Input.GetAxis("Horizontal") * rotationSpeed;
        vertical = Input.GetAxis("Vertical") * speed;


        horizontal *= Time.deltaTime;
        vertical *= Time.deltaTime;

        transform.Translate(horizontal, 0, vertical);
        transform.Rotate(0, mouseX, 0);
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
