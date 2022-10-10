using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
   /* GameObject player; //References to the player so we can track its poition
    Renderer rend; //Reference to the Render so we xan modify its texture

    float playerStartPost; //Float used to track the starting position of the player
    public float speed = 0.5f; //How fast should we scroll? We change this for each layer
        
    
    void Start()
    {
        player = GameObject.Find("Player"); //Find the player
        rend = GetComponent<Renderer>(); //Find the render
        playerStartPost = player.transform.position.x; //Save our starting position
    }

    // Update is called once per frame
    void Update()
    {
        float offset = (player.transform.position.x - playerStartPost) * speed;

        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0f));
        
    }*/
}
