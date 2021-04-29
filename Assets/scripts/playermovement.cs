using UnityEngine;

public class playermovement : MonoBehaviour
{

    public Rigidbody rb;

    //creating a float variable so I can edit it in the inspector. 
    public float forwardForce = 2000f;
    public float SidewaysForce = 500f;
    public float UpwardForce = 100f;
    public float Gravity = 100f; 

    // Start is called before the first frame update
    public bool PlayerOnGround = true;

    // we marked this "fixed" update because we are using it to mess with physics
    void FixedUpdate()
    {
        //add a forward force
        
       rb.AddForce(0, 0, forwardForce * Time.deltaTime);
       
        //ending the game if an object has been hit 
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

  
        if (Input.GetKey("d") && PlayerOnGround)
        {
            Debug.Log("right");
            //right
            rb.AddForce(new Vector3(SidewaysForce * Time.deltaTime, 0, 0), ForceMode.VelocityChange);
          
        }
        if (Input.GetKey("a") && PlayerOnGround)
        {
            //left
            Debug.Log("left");
            rb.AddForce(new Vector3(-SidewaysForce * Time.deltaTime, 0, 0), ForceMode.VelocityChange);
            
            
        }


        if (Input.GetKey("w") && PlayerOnGround)
        {
            //jump
            Debug.Log("Jump");
            rb.AddForce(new Vector3(0, UpwardForce, 0), ForceMode.Impulse);
            PlayerOnGround = false;
        }

        if (Input.GetKey("s") && PlayerOnGround)
        {
            //jump
            Debug.Log("roll");
            rb.AddForce(new Vector3(0,
                                    -UpwardForce,
                                    0), ForceMode.Impulse);
            PlayerOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
           
            PlayerOnGround = true;


        }


    }
}



