using TMPro;
using UnityEngine;

public class Kill : MonoBehaviour
{
    public TextMeshProUGUI text;
    public byte count = 0;
    public void KillPlayer()
    {
        if (count < 3)
        {
            count++;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().Dead(true);
            text.text = (3 - count).ToString() + "/3";
        }
    }
    public void ResetCounter()
    {
        count = 0;
        text.text = (3 - count).ToString() + "/3";
    }
}
