using UnityEngine;
using UnityEngine.Advertisements;
using UnityStandardAssets.CrossPlatformInput;

public class Movement : MonoBehaviour
{
    public int coin;
    public GameObject dead;
    byte deadCounter = 0;
    public Vector3 start;
    public float speed = 0;
    public float jumpSpeed = 0;
    int jumps = 2;
    int startJumps = 2;
    public Rigidbody2D rb;
    public float move = 0;
    public bool jumping = false;
    bool faceRight = true;
    GameObject map;
    public void SaveCoins()
    {

        PlayerPrefs.SetInt("PlayerCoins", PlayerPrefs.GetInt("PlayerCoins") + coin);
    }
    private void Awake()
    {
        map = GameObject.FindGameObjectWithTag("Map");
        start = gameObject.transform.position;

    }
    public void Dead(bool on)
    {
        deadCounter++;
        if (deadCounter == 5 && Advertisement.IsReady())
        {
            deadCounter = 0;
            Advertisement.Show("video");
        }
        if (on)
        {
            //GetComponent<CameraShake>().ShakeCamera(20f, 1f);
            map = GameObject.FindGameObjectWithTag("Map");
            Instantiate(dead, gameObject.transform.position, Quaternion.identity, map.transform);
        }

        this.gameObject.transform.position = start;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dead"))
        {
            Dead(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Death"))
        {
            jumps = startJumps;
        }
    }
    void FixedUpdate()
    {

        //move = Input.GetAxisRaw("Horizontal");

        move = CrossPlatformInputManager.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
        if (jumps > 0 && jumping == true)
        {

            Jump();
        }
        jumping = false;

        if (faceRight == false && move > 0)
        {
            Flip();
        }
        else if (faceRight == true && move < 0)
        {
            Flip();
        }
    }
    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        jumps--;
    }


    void Flip()
    {
        faceRight = !faceRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
