using UnityEngine;

public class Mute : MonoBehaviour
{
    public AudioSource audioSource;
    bool stop = false;
    public void Stop()
    {
        if (stop)
        {
            audioSource.Play();
            stop = false;
        }
        else
        {
            audioSource.Pause();
            stop = true;

        }
    }
}
