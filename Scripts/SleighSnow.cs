using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleighSnow : MonoBehaviour
{
    public float distanceFromParent = 1.0f; // Adjust this to set the distance from the parent

    private Transform parentTransform;

    void Start()
    {
        parentTransform = transform.parent.transform;
    }

    void Update()
    {
        // Keep the child object's position relative to the parent, but at a fixed distance below it
        Vector3 newPosition = parentTransform.position;
        newPosition.y -= distanceFromParent;
        transform.position = newPosition;
    }
}
