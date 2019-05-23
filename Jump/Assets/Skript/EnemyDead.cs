using UnityEngine;

public class EnemyDead : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public GameObject Enemy;
    public GameObject Coin;
    GameObject map;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            map = GameObject.FindGameObjectWithTag("Map");
            Destroy(boxCollider);
            Vector2 vector2 = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 1);
            Instantiate(Enemy, gameObject.transform.position, Quaternion.identity, map.transform);
            Instantiate(Coin, vector2, Quaternion.identity, map.transform);
            Destroy(gameObject);
        }
    }
}
