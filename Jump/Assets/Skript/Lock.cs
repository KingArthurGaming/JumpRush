using UnityEngine;
using UnityEngine.UI;

public class Lock : MonoBehaviour
{

    void Update()
    {
        if (PlayerPrefs.GetInt(gameObject.name)==1)
        {
            Button button = GetComponent<Button>();
            button.interactable = true;
            Image image = GetComponent<Image>();
            image.color = Color.HSVToRGB(0f, 0f, 1f);
        }
    }

   
}
