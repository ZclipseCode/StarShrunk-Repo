using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    [SerializeField]
    private float duration = 1f;
    public AnimationCurve curve;
    public bool start = false;

    void Update()
    {
        if(start)
        {
            start = false;
            StartCoroutine(Shaking());
        }
    }

    IEnumerator Shaking()
    {
        Vector3 startposition = transform.position;
        float elapsedTime = 0f;

        while(elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float strength = curve.Evaluate(elapsedTime / duration);
            transform.position = startposition + Random.insideUnitSphere * strength;
            yield return null;
        }

        transform.position = startposition;
    }
}
