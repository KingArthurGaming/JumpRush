using UnityEngine;

public class BetterJump : MonoBehaviour
{
    public float fallMulti = 2.5f;
    public float lowMulti = 2f;
    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics.gravity.y * (fallMulti - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics.gravity.y * (lowMulti - 1) * Time.deltaTime;
        }
    }
}
