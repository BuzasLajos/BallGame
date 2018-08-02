using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Camera;
    public Transform Target;
    public float distance = 15.00F; //-10
    public float lift = 15.00F;

	// Use this for initialization
	void Start () {
		   //     transform.position = new Vector3(0.0f, 1.5f, 0.0f);

	}
	
	// Update is called once per frame
	void Update() {
 transform.position = new Vector3(Ball.transform.position.x      , 
 Ball.transform.position.y + lift     ,  
 Ball.transform.position.z  + 5.00f              ); 

    }
}
