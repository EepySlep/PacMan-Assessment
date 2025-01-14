using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; //Speed at which Pac-Man moves.

    private Vector3 moveDirection; //Stores movement direction.

    void Update()
    {
        //Old input system utilising W,A,S,D as the main source of movement.
        moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) //Moving up.
        {
            moveDirection = Vector3.up;
        }
        else if (Input.GetKey(KeyCode.S)) //Moving down.
        {
            moveDirection = Vector3.down;
        }
        else if (Input.GetKey(KeyCode.A)) //Moving left.
        {
            moveDirection = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.D)) //Moving right.
        {
            moveDirection = Vector3.right;
        }

        //Move Pac-Man according to the time taken from player input.
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
