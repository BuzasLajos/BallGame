using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move : MonoBehaviour {


    int rotationSpeed = 100;
    int jumpHeight = 8;
  //  bool playOnce = true;

    public AudioClip hit01;
    public AudioClip hit02;
    static AudioClip hit03;

    private bool isFalling = false;
    public static float distToGround;

    // Use this for initialization
    void Start ()
    {
        //Getting the center from the center to the ground
        distToGround = GetComponent<Collider>().bounds.extents.y;

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
        if ( (Input.GetKeyDown(KeyCode.Space) || (Input.GetMouseButtonDown(0))) && IsGrounded() )
        {
            Vector3 v3 =  GetComponent<Rigidbody>().velocity;
            v3.y = jumpHeight;
            GetComponent<Rigidbody>().velocity = v3;
            
        }


	}//Update
    

    void OnCollisionEnter() {


        System.Random rnd = new System.Random();
        int theHit = rnd.Next(1, 4); // creates a number between 1 and 4
        if (theHit == 1) { GetComponent<AudioSource>().clip = hit01; }
        else if (theHit == 2) { GetComponent<AudioSource>().clip = hit02; }
        else { GetComponent<AudioSource>().clip = hit03; }

        System.Random rnd2 = new System.Random();
        double thePitch = rnd2.NextDouble() * (1.1 - 0.8) + 0.8;
        Debug.Log("theHit: " + theHit + " \nthePitch: " + thePitch);

        GetComponent<AudioSource>().pitch = (float)thePitch;
        GetComponent<AudioSource>().PlayDelayed(0);


    }

    //Check that if we are on the ground
     bool IsGrounded() {
        return Physics.Raycast(transform.position, - Vector3.up, distToGround + 0.1f);
    }

    //Generate float numbers
    static float NextFloat(System.Random random)
    {
        double mantissa = (random.NextDouble() * 2.0) - 1.0;
        double exponent = System.Math.Pow(2.0, random.Next(-126, 128));
        return (float)(mantissa * exponent);
    }
}
