using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{
    [SerializeField] GameObject beam;
    [SerializeField] Transform beamPoint;
    [SerializeField] float timeBetweenShots;
    float timer;

    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeBetweenShots)
        {
            Shoot();

            timer = 0;
        }
    }

    void Shoot()
    {
        Instantiate(beam, beamPoint.position, beam.transform.rotation);
    }
}
