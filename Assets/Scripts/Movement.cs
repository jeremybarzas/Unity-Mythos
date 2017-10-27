
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;

    float leftStickX;
    float leftStickZ;


    void Move()
    {
        leftStickX = Input.GetAxis("LeftStickX") * speed;
        leftStickZ = Input.GetAxis("LeftStickZ") * speed;


        leftStickX *= Time.deltaTime;
        leftStickZ *= Time.deltaTime;

        transform.Translate(leftStickX, 0, -leftStickZ);
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
