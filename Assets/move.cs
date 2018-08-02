using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move : MonoBehaviour {


    int rotationSpeed = 100;
    int jumpHeight = 8;

    private bool isFalling = false;

    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {
        //Handle ball rotation
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        //rigidbody.AddRelativeTorque(Vector3.back * rotation);
        GetComponent<Rigidbody>().AddRelativeTorque(Vector3.back * rotation);

        //Handle ball rotation
        float rotation2 = Input.GetAxis("Vertical") * rotationSpeed;
        rotation2 *= Time.deltaTime;
        //rigidbody.AddRelativeTorque(Vector3.back * rotation);
        GetComponent<Rigidbody>().AddRelativeTorque(Vector3.left * rotation2);

        //Handle ball jump
        if (Input.GetKeyDown(KeyCode.Space) && isFalling == false)
        {
            Vector3 v3 =  GetComponent<Rigidbody>().velocity;
            v3.y = jumpHeight;
            GetComponent<Rigidbody>().velocity = v3;
        }
        isFalling = true;

	}//Update
    void OnCollisionStay() { isFalling = false; }

}
