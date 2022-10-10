using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Creat a public array of objects to spwan, we will fill this up using the Unity Editor
     public GameObject[] objectsToSpawn;

     float timeToNextSpawn;      //Track how long we should wait before spawning a new object 
     float timeSinceLastSpawn = 0.0f; //Track the time since we last spawned something 

     public float minSpawnTime = 0.5f; //Minium the amount of time between spawing objects
     public float maxSpawnTime = 3.0f; //Maxium amount of time between the spwaning objectd

    void Start()
    { 
        //Random.Range returns a random float between values 
        timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
        
    }

    
    void Update()
    {    
        //Add Time.deltaTime returns the amount of time passed since the last time frame.
         //This will creat a float that count up in seconds
         timeSinceLastSpawn = timeSinceLastSpawn + Time.deltaTime;

        //if we've counted past the amount of time we need to wait...
        if (timeSinceLastSpawn > timeToNextSpawn)
        {

            //use Random.Range to pick a number between 0 and the amount of items we have on our object list 
            int selection = Random.Range(0, objectsToSpawn.Length);

            //InstantLate spwans a GameObject - in this case we tell it to spwan a GameObject from our objectToSpawn list
            //The Second parmeter in the brackets tells it where to spwan, so we've entered the position of the spwaner.
            Instantiate(objectsToSpawn[selection], transform.position, Quaternion.identity);

            //After spwaning, we select a new random time for the next spwan and set our timer back to zero 
            timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            timeSinceLastSpawn = 0.0f;
        }
    }
}
