
using UnityEngine;

public class NewEnemy : MonoBehaviour
{
    int counter = 0;
    public bool moveRight = true;
    public float speed = 1;
    public Transform groundDetect;
    public Transform wallDetect;
    private void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D wallInfo = new RaycastHit2D();
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetect.position, Vector2.down, 0f);
        if (moveRight)
        {
             wallInfo = Physics2D.Raycast(wallDetect.position, Vector2.right, 0f);
        }
        else
        {
             wallInfo = Physics2D.Raycast(wallDetect.position, Vector2.left, 0f);
        }
        if (wallInfo.collider == true)
        {
            Flip();
        }
        if (groundInfo.collider == false)
        {
            counter++;
            if (counter == 500)
            {
                Destroy(this.gameObject);
            }
            Flip();
        }
    }
    void Flip()
    {
        if (moveRight)
        {
            transform.eulerAngles = new Vector2(0, 180);
            moveRight = false;
        }
        else
        {
            transform.eulerAngles = new Vector2(0, 0);

            moveRight = true;
        }
    }


}