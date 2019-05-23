using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class Lock300 : MonoBehaviour
{
    GameObject thisObject;
    public GameObject needMoney;
    public int locked;
    void Start()
    {
        thisObject = gameObject;
        //PlayerPrefs.SetInt(thisObject.name, 1);
        locked = PlayerPrefs.GetInt(thisObject.name);
        if (locked == 1)
        {
            Destroy(gameObject);
        }
    }
   
    public void Buy()
    {
        if (PlayerPrefs.GetInt("PlayerCoins") >= 300)
        {
            int temp = PlayerPrefs.GetInt("PlayerCoins");
            PlayerPrefs.SetInt("PlayerCoins", temp - 300);
            PlayerPrefs.SetInt(thisObject.name, 1);
            Debug.Log(thisObject.name);
            Destroy(gameObject);
        }
        else if (Advertisement.IsReady())
        {
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<Animator>().Play("BonusOpen");

        }
        Debug.Log(Advertisement.IsReady());
    }
}
