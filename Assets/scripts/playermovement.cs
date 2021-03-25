using UnityEngine;

public class playermovement : MonoBehaviour
{

    public Rigidbody rb;

    //creating a float variable so I can edit it in the inspector. 
    public float forwardForce = 2000f;
    public float SidewaysForce = 500f;
    public float downwardForce = 1000f;
    // Start is called before the first frame update
    public bool PlayerOnGround = true; 

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



        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        //making the player jump
        if(Input.GetButtonDown("Jump") && PlayerOnGround){
            rb.AddForce(new Vector3(0, 20, 0), ForceMode.Impulse);
            PlayerOnGround = false; 
        }
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Debug.Log("jump");
            PlayerOnGround = true;
        }

    }
    

}

