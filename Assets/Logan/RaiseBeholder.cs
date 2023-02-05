using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseBeholder : MonoBehaviour
{
    public static bool start = false;
    void Update()
    {
        if (start)
        {
            transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        }
    }
}
