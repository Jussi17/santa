using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaRising : MonoBehaviour
{
    [SerializeField] public float _speed;

    private void Update()
    {
        transform.position += new Vector3(0, _speed, 0);
    }
}
