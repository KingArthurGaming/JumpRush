﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respown : MonoBehaviour {

     Vector2 vector;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<Movement>().Dead(false);
        }
    }
}
