using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMove : MonoBehaviour
{
    private Vector3 moveDirection; //Stores movement direction.
    public float Speed = 2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Way2") ; //Checks if the object has met an object and turns the other way once collided.
        {
            moveDirection = Vector3.left;
        }

    }

    private void Update()
    {
        transform.Translate(moveDirection * Speed * Time.deltaTime);
    }
}
