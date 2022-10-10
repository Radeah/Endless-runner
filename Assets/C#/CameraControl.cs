using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //Creat a public reference to the player - we will assign this using unity editor 
     public GameObject player;   
    
        
    

    // Update is called once per frame
    void Update()
    {
        //Chnage our position relative to the player position
         transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }
}
