using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {
    public Animator Anim;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")&&GameObject.FindObjectOfType<LevelGenerator>().index<43)
        {
            FindObjectOfType<Movement>().SaveCoins();
            FindObjectOfType<FindPlayer>().Find();

            PlayerPrefs.SetInt((int.Parse(FindObjectOfType<LevelGenerator>().map.name) + 1).ToString(), 1);
            Debug.Log((int.Parse(FindObjectOfType<LevelGenerator>().map.name) + 1).ToString());
            Anim = FindObjectOfType<Canvas>().GetComponent<Animator>();
            Anim.Play("FinishOpen");

        }
        else if(collision.CompareTag("Player"))      
        {
            Anim = FindObjectOfType<Canvas>().GetComponent<Animator>();
            FindObjectOfType<FindPlayer>().Find();
            Anim.Play("FinishBonusOpen");
            FindObjectOfType<Movement>().SaveCoins();
        }
    }
}
