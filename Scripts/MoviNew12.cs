using UnityEngine;

public class MoviNew12 : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public float speed = 2f;
    public float pauseTime = 2f;
    private SpriteRenderer sprite;
    private Vector3 currentTarget;
    public bool isPaused = false;

    void Start()
    {
        currentTarget = point2.position;
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (!isPaused)
        {
            sprite.color = new Color(1,0.8622f,0.8622f,1);
            transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

            if (transform.position == point1.position)
            {
                isPaused = true;
                Invoke("ResumeMovement", pauseTime);
            }
            else if (transform.position == point2.position)
            {
                isPaused = true;
                Invoke("ResumeMovement", pauseTime);
            }
        }
        if (isPaused)
        {
            sprite.color = Color.white;
        }
    }

    void ResumeMovement()
    {
        if (currentTarget == point1.position)
        {
            currentTarget = point2.position;
        }
        else
        {
            currentTarget = point1.position;
        }

        isPaused = false;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.collider.transform.SetParent(transform);
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.collider.transform.SetParent(null);
        }
    }
}