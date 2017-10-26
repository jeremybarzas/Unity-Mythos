using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject Player;
    public float distance;

    // Use this for initialization
    void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Player.transform.position;

        transform.forward = Player.transform.forward;
    }
}
