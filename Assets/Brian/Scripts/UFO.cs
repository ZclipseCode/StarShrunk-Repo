using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{
    [SerializeField] GameObject beam;
    [SerializeField] Transform beamPoint;
    [SerializeField] float timeBetweenShots;
    float timer;
    [SerializeField] float beamSpeed;

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
        GameObject newBeam = Instantiate(beam, beamPoint.position, Quaternion.identity );
        newBeam.GetComponent<Transform>().rotation = transform.rotation;
        newBeam.GetComponent<Rigidbody2D>().velocity = -transform.up * beamSpeed;
    }
}
