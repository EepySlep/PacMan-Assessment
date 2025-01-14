using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{

    //This checks if the player is over a pellet and then deletes it if this happens.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Collectible") ; //All objects stored under this tag are susceptible to being interacted with by the player.
        {
            print("Collected"); //The print function displays a debug message to the console, which was a functionality test.
            gameObject.active = false; //Delete the object interacted with.
        }
    }
}
