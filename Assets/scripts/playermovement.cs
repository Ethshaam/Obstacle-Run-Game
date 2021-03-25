using UnityEngine;

public class playermovement : MonoBehaviour
{

    public Rigidbody rb;

    //creating a float variable so I can edit it in the inspector. 
    public float forwardForce = 2000f;
    public float SidewaysForce = 500f;
    // Start is called before the first frame update


    // we marked this "fixed" update because we are using it to mess with physics
    void FixedUpdate()
    {
           //add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if( Input.GetKey("d"))
        {
            //only execute when condition is met
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            //only execute when condition is met
            rb.AddForce(- SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

       
    }
}
