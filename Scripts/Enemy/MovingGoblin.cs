using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGoblin : MonoBehaviour
{
    public List<Transform> points;
    [SerializeField] private Transform leftEdge;
    [SerializeField] private Transform rightEdge;
    private bool movingLeft;
    [SerializeField] private float idleDuration;
    private float idleTimer;
    public Transform platform;
    int goalPoint = 0;
    public float moveSpeed = 2;
    private Animator anim;
    public GameObject goblin;

    private Vector3 initScale;
    private void Awake()
    {
        initScale = platform.localScale;
    }

    private void Start()
    {

        anim = goblin.GetComponent<Animator>();
        anim.SetBool("moving", true);
    }

    private void Update()
    {
        MoveToNextPoint();

        if (movingLeft)
        {
            if (platform.position.x >= leftEdge.position.x)
                MoveInDirection(-1);
            else
                DirectionChange();
        }
        else
        {
            if (platform.position.x <= rightEdge.position.x)
                MoveInDirection(1);
            else
                DirectionChange();
        }
    }

    private void DirectionChange()
    {
        anim.SetBool("moving", false);

        idleTimer += Time.deltaTime;

        if (idleTimer > idleDuration)
            movingLeft = !movingLeft;
    }

    private void MoveInDirection(int _direction)
    {
        idleTimer = 0;
        anim.SetBool("moving", true);

        platform.localScale = new Vector3(Mathf.Abs(initScale.x) * _direction, initScale.y, initScale.z);

        platform.position = new Vector3(platform.position.x + Time.deltaTime * _direction * moveSpeed,
            platform.position.y, platform.position.z);
    }


    void MoveToNextPoint()
    {
        platform.position = Vector2.MoveTowards(platform.position, points[goalPoint].position, 1 * Time.deltaTime * moveSpeed);

        if (Vector2.Distance(platform.position, points[goalPoint].position) < 0.1f)
        {
            if (goalPoint == points.Count - 1)
                goalPoint = 0;
            else
                goalPoint++;
        }
    }


}

