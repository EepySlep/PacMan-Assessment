using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMove : MonoBehaviour
{
    //ChatGPT assisted with the debugging process of the object movement loop, suggesting I use box colliders for the empty objects.
    private Vector3 moveDirection;
    public float Speed = 2f;

    private void Start()
    {
        //See player script.
        moveDirection = Vector3.right;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Checks if object is moving right and if colliding with the object, it will turn left.
        if (collision.gameObject.tag == "Way2")
        {
            moveDirection = Vector3.left; // Move left.
        }
        //Same as above, but the opposite direction.
        else if (collision.gameObject.tag == "Way1")
        {
            moveDirection = Vector3.right; // Move right.
        }
    }

    private void Update()
    {
        //See player script.
        transform.Translate(moveDirection * Speed * Time.deltaTime);
    }
}


