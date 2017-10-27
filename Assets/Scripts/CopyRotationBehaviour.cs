using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyRotationBehaviour : MonoBehaviour
{
    public Transform copyFrom;    

    // Use this for initialization
    void Start ()
    {
        transform.rotation = new Quaternion(transform.rotation.x, copyFrom.rotation.y, transform.rotation.z, transform.rotation.w);
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.rotation = new Quaternion(transform.rotation.x, copyFrom.rotation.y, transform.rotation.z, transform.rotation.w);
	}
}
