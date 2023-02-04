using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCore : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    float overTime;

    void Start()
    {

    }

    void Update()
    {
        overTime += Time.deltaTime;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotationSpeed * overTime));
    }
}
