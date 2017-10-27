using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject camera;

    public float movementSpeed;

    void Move()
    {   
        // Keyboard transform of player
        float horizontal = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;      
        
        transform.Translate(horizontal, 0, vertical);
               
        transform.rotation = new Quaternion(transform.rotation.x, camera.transform.localRotation.y, transform.rotation.z, transform.rotation.w);        
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
