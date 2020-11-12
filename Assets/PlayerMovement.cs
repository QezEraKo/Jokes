
using UnityEngine;
//Here I remove the 2 first lines since I only need UnityEngine.


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;
    // This will create a new option under the PlayerMovement script where I have set the default speed to ''2''
    Rigidbody2D rigidBody;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
        //Here I  use FixedUpdate to have a steady ''call' every 20ms. if I used ''Update'' I could possibly pass trough walls during a spike lagg, since my update time would be prologed during this.
    {
        Vector3 input = Vector3.zero;
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        // here I use Raw after Getaxis to make the player stop instantly after releasing a movement button. I tried without raw and it made the player slide. this was unconfortable.
        // Easy way to use unity to get around  ''if (input.GetKeyDown(KeyCode.D)) { Movement.x = 1;}''  this method allso allows for easier use of controller if needed.
        Vector3 direction = input.normalized;
        //Here I put Normalized because: if movement vecort on W is 1 and movement vector on D is 1, My movement on WD combined (moving diagonal) would be greater (1,415 to be exact), use a graph to visualise this.  
        Vector3 movement = direction * speed * Time.fixedDeltaTime;
        //I could use Time.deltaTime for this, but with fixedDeltaTime I can make a unit move 60 units per secoind even if I only had 30 FPS.
        rigidBody.MovePosition(transform.position + movement);
    }
    
    //the following line will be a line I will need for the trigger fuction to work.
    //this took me alot of time to figure out I needed.
    //I will create debug commands so I can see if I correctly collide, and trigger.
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Trigger-Enter!");
    }
    //The previous fuction will be called when the player collides with a trigger
    private void OnTriggerStay2D(Collider2D collision)
    //This fuction will be called when the player is activly triggering.
    {
        Debug.Log("Trigger-Stay!");
    }

    private void OnTriggerExit2D(Collider2D collider)
        //This function will be called when the player is exiting a trigger
    {
        Debug.Log("Trigger-Exit!");
    }

    private void OnCollisionEnter2D(Collision2D collider)
        //Notice the difference in the (), where I write collision2D instead of Collider2D.
        //Collision will give information about alot of stuff. Like contact points and velocity.
        //This function will be called when the player first collides with a wall/collider.
    {
        Debug.Log("Collision-Enter");
    }

    private void OnCollisionStay2D(Collision2D collider)
        //This function will be called when the player is activly colliding with the wall/collider.
    {
        Debug.Log("Collision-Stay!");
    }

    private void OnCollisionExit2D(Collision2D collider)
        //this function will be called when the player stops colliding with the wall/collider.
    {
        Debug.Log("Collision-Exit!");
    }
}