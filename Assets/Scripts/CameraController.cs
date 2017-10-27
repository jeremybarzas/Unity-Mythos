using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    public float mouseSensitivity = 100;

    float rotX;
    float rotY;

    // Use this for initialization
    void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
    }

    // Update is called once per frame
    void Update()
    {
        //this is to rotate camera with mouse or joystick
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotY += mouseX * mouseSensitivity * Time.deltaTime;
        rotX -= mouseY * mouseSensitivity * Time.deltaTime;

        transform.rotation = Quaternion.Euler(rotX, rotY, 0.0f);

        //this is to make the camara face the same direction as the character
        transform.position = player.transform.position;
    }
}
