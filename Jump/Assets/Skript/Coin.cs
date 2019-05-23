using UnityEngine;

public class Coin : MonoBehaviour
{
    int levelCoins = 0;
    public CircleCollider2D circle;
    public SpriteRenderer spriteRenderer;
    public ParticleSystem particle;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(circle);
            Destroy(spriteRenderer);
            particle.Play();
            FindObjectOfType<Movement>().coin++;
            Destroy(gameObject, 1.2f);
        }
    }
    
}
