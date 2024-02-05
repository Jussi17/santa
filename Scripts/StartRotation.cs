using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRotation : MonoBehaviour
{
    public GameObject puuKasa;
    void Start()
    {
        transform.rotation = puuKasa.transform.rotation;
    }

}
