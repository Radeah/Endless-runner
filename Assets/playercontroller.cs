using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{

    public GameObject groundChecker;
    public LayerMask whatIsGround;
    public Animator anim;

    float maxSpeed = 5.0f;
    bool isOnGround = false;

    // Creat a reference to the Rigibody 2D so we can manipulate it 
    Rigidbody2D playerObject;

    private float speed = 8.9f;
    

    // Start it caleed before the first frame update 
    void Start()
    {
         //Find the Rigibody2D componet that is attached to the same object as this script 
         playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()

    {
        if (Input.GetKey(KeyCode.LeftShift))
        {

        }  
        else
        {
            maxSpeed = 5.0f;

        }

        //Set momvemtValueX to 1.0f, so that we always run foraward and no longer care about player input
        float movementValueX = 1.0f;
        
        //Chnage the x velocity of the Rigidbody2D to be equal to the movment value
        playerObject.velocity = new Vector2 (movementValueX * speed, playerObject.velocity.y);

        //check to see if the ground check object is touching the ground
        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 0.5f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true){
            playerObject.AddForce(new Vector2(0.0f, 850.0f));
        }
        anim.SetFloat("speed", movementValueX);
    }

}
