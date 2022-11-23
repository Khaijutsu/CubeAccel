using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;
    // Start is called before the first frame update

    // Update is called once per frame
    // We marked this as  "Fixed"Update because we are using it to mess with physics.
    // Time.deltaTime evens out the advantage one would get for a good computer, since there is higher framework compared to a slwoer computer
    // Higher framerate(ususally for better computers), the lower the value of Time.deltaTime 
    void FixedUpdate()
    {
        // Add a forward force
        // AddForce(moves (-)left/right, (-)down/up, (-)backward/forward)
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
