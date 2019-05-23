using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveLevel : MonoBehaviour
{
    public void LevelSelect()
    {
        FindObjectOfType<LevelGenerator>().GenerateLevel(int.Parse(gameObject.name));
    }
}
