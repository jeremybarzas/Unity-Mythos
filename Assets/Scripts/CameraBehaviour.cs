using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject Player;

    public float rightStickSensitivy = 100.0f;
    public float clampAngle = 80.0f;

    float distance;

    float rotX;
    float rotY;

    // Use this for initialization
    void Start ()
    {
        
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
    }
	
	// Update is called once per frame
	void Update ()
    {

        transform.forward = Player.transform.forward;

        //this is to rotate camera with mouse or joystick
            float controllerX = Input.GetAxis("RightStickX");
            float controllerY = Input.GetAxis("RightStickY");

            rotY += controllerX * rightStickSensitivy * Time.deltaTime;
            rotX -= controllerY * rightStickSensitivy * Time.deltaTime;

            rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);
            

            transform.rotation = Quaternion.Euler(rotX, rotY, 0.0f);
            
        
        //this is to make the camara face the same direction as the character
        transform.position = Player.transform.position;
       
    }
}
