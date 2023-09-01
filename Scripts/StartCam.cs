using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCam : MonoBehaviour
{
    private float shakeIntensity = 1;
    void Start()
    {
        StartCoroutine(ShakeCamera());
    }

    IEnumerator ShakeCamera()
    {
        yield return new WaitForSeconds(4f);
        Vector3 originalPos = transform.position;
        float shakeTime = 0.7f; // The duration of the shake
        float elapsedTime = 0f;

        while (elapsedTime < shakeTime)
        {
            float x = originalPos.x + Random.Range(-shakeIntensity, shakeIntensity) * Mathf.PerlinNoise(Time.time * 10f, 0f);
            float y = originalPos.y + Random.Range(-shakeIntensity, shakeIntensity) * Mathf.PerlinNoise(0f, Time.time * 10f);
            transform.position = new Vector3(x, y, originalPos.z);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = originalPos;
    }

}
