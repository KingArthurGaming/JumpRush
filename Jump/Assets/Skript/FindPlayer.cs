using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayer : MonoBehaviour
{
    public void Find()
    {
        
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().bodyType != RigidbodyType2D.Static)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
        else
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        }
    }
}
