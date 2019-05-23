using UnityEngine;

public class Jump : MonoBehaviour
{
    public GameObject player;
    public void JumpNow()
    {
        //player.GetComponent<Movement>().Jump();
        player.GetComponent<Movement>().jumping = true;
    }


    private void FixedUpdate()
    {
        if (player != null)
        {
            return;
        }
        player = GameObject.FindGameObjectWithTag("Player");
    }
}