using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float sidewayForce = 2000f;

    // Update is called once per frame
    void FixedUpdate()
    {   
        rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        if (transform.position.x > 0) {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }
       
        
    }
}
