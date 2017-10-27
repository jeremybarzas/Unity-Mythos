using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyRotationBehaviour : MonoBehaviour
{
    public GameObject player;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        //float MouseY = Input.GetAxis("MouseY");
        transform.rotation = new Quaternion(transform.rotation.x, player.transform.rotation.y, transform.rotation.z, transform.rotation.w);
	}
}
