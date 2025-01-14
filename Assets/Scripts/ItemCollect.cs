using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{

    //This checks if the player is over a pellet and then deletes it if this happens. The print function displays a debug message to the console, which was a functionality test.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Collectible") ;
        {
            print("Collected");
            gameObject.active = false;
        }
    }
}
