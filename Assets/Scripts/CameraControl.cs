using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Camera;
    public Transform Target;
    public float distance = 10.00F; //-10
    public float lift = 10.00F;

	// Use this for initialization
	void Start () {
		   //     transform.position = new Vector3(0.0f, 1.5f, 0.0f);

	}
	
	// Update is called once per frame
	void Update() {
 transform.position = new Vector3(Ball.transform.position.x     , 
 Ball.transform.position.y + lift  +1.00F   ,  
 Ball.transform.position.z  - 7.00F              );
        transform.LookAt(Ball.transform);

    }
}
