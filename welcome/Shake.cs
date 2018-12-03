using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public float shakeTime = 5.0f, shakeAmount = 10.0f, shakeSpeed = 2.0f;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(ShakeTitle());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator ShakeTitle()
    {
        Vector3 originalPosition = transform.position;
        float timer = 0.0f;

        while (true)
        {
            Vector3 randomPosition = originalPosition + Random.insideUnitSphere * shakeAmount;
            transform.position = Vector3.Lerp(transform.position, randomPosition, Time.deltaTime * shakeSpeed);

            yield return null;
            timer += Time.deltaTime;
        }
    }
}
