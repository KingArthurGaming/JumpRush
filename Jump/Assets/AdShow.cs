using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdShow : MonoBehaviour
{
    public GameObject level;
    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo");

            level.GetComponent<LevelGenerator>().GenerateLevel(Random.Range(43,49));
        }
    }
}
