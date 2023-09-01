using UnityEngine;

public class EnemyProjectile90 : EnemyDamage
{
    [SerializeField] private float speed;
    [SerializeField] private float resetTime;
    private float lifetime;

    public void ActivateProjectile()
    {
        lifetime = 0;
        gameObject.SetActive(true);
    }
    private void Update()
    {
        float movementSpeed = speed * Time.deltaTime;
        transform.Translate(movementSpeed, 0, 0);

        lifetime += Time.deltaTime;
        if (lifetime > resetTime)
            gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Reindeer")
        {
            collision.GetComponent<Health90>().TakeDamage(damage);
            gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Rounded" || collision.gameObject.tag == "Water" || collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Puu" || collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "MovingPlatform" || collision.gameObject.tag == "Grab")
        {
            gameObject.SetActive(false);
        }

    }
}