﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Collectible") ;
        {
            print("Collected");
            gameObject.active = false;
        }
    }
}
