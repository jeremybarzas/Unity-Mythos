using UnityEngine;
using System.Collections;

public class cameraOrbitBehaviour : MonoBehaviour
{

    public Transform target;
    public float distance = 5.0f;
    public float orbitSpeed = 1.0f;
    
    float x = 0.0f;
    float y = 0.0f;

    // Use this for initialization
    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
        
    }

    void Update()
    {
        y += orbitSpeed * distance * 0.02f;

        Quaternion rotation = Quaternion.Euler(33, y, 0);

        Vector3 negDistance = new Vector3(0.0f, 0.0f, -distance);
        Vector3 position = rotation * negDistance + target.position;

        transform.rotation = rotation;
        transform.position = position;
    }   
}