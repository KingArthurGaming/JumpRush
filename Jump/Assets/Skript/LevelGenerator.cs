using System.Collections;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Animator anim;
    public Texture2D[] maps;
    public Texture2D map;
    GameObject levelElements;
    public ColorToPrefab[] colorMappings;
    public int index;

    public void Next()
    {
        Destroy(levelElements);
        GenerateLevel(index + 1);
    }
    public void Destroy()
    {
        Destroy(levelElements);

    }
    public void Restart()
    {
        Destroy(levelElements);
        GenerateLevel(index);
    }
    IEnumerator level1()
    {
        yield return new WaitForSeconds(2.4f);
        anim.Play("level1Tutorial");

    }

    IEnumerator level3()
    {
        yield return new WaitForSeconds(2.5f);
        anim.Play("DeadOpen");

    }

    public void GenerateLevel(int mapIndex)
    {
        index = mapIndex;
        map = maps[mapIndex - 1];
        if (mapIndex == 3)
        {
            StartCoroutine(level3());
        }
        else if (mapIndex == 1)
        {
            StartCoroutine(level1());
        }
        levelElements = new GameObject("Map");
        levelElements.tag = "Map";
        for (int x = 0; x < map.width; x++)
        {
            for (int y = 0; y < map.height; y++)
            {
                GenerateTile(x, y);
            }
        }
    }

    void GenerateTile(int x, int y)
    {
        Color pixelColor = map.GetPixel(x, y);

        if (pixelColor.a == 0)
        {
            return;
        }

        foreach (ColorToPrefab colorMapping in colorMappings)
        {
            if (colorMapping.color.Equals(pixelColor))
            {
                Vector2 position = new Vector2(x, y);
                Instantiate(colorMapping.prefab, position, Quaternion.identity, levelElements.transform);
            }
        }
    }

}
