using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Social : MonoBehaviour
{
    public void Facebook()
    {
        Application.OpenURL("https://www.facebook.com/profile.php?id=100004423176357");
    }
    public void Instagram()
    {
        Application.OpenURL("https://www.instagram.com/king_arthur_gaming/");
    }
    public void Soundcloud()
    {
        Application.OpenURL("https://soundcloud.com/vichevmusic");
    }
    public void Gamejolt()
    {
        Application.OpenURL("https://gamejolt.com/@KING_ARTHUR_GAMING");
    }
}
