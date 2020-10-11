
using UnityEngine;

public class playermovement : MonoBehaviour {
    // Reference for Rigidbody
public Rigidbody rb;

    public float forwardForce = 2000f;
    public float SidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate ()
    {
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);  
        // moving left and right
        if (Input.GetKey("d") )
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0);
        }

    }
}
// Taken from Brackeys
