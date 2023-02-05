using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRay : MonoBehaviour
{
    RaycastHit2D hit;
    [SerializeField] float distance;
    [SerializeField] Transform rayPoint;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        hit = Physics2D.Raycast(rayPoint.position, rayPoint.up, distance);
        if (hit.collider != null)
        {
            if (hit.collider.tag == "Planet")
            {
                Debug.DrawLine(rayPoint.position, hit.point, Color.white);
                Debug.Log("Hit");
            }
        }
    }
}
