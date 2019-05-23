using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsShow : MonoBehaviour
{
    public TextMeshProUGUI TextMesh;
    // Update is called once per frame

    void Update()
    {
        TextMesh.text = PlayerPrefs.GetInt("PlayerCoins").ToString();
    }
}
