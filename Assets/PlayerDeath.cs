using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    //This will be called when the player collides with an enemy, ensuring an instant kill.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) //Collision checks for a specific tag, since it is looking for the enemy object to collide with.
        {
            // Destroy the player object instantly
            gameObject.active = false; //See ItemCollect for the same function.
        }
    }
}
