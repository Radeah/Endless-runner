using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colltiable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //destroy your game object(pickup/collectable) and do whatever you want it to do

            Destroy(gameObject);

        }
    }
}
