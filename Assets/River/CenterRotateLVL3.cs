using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterRotateLVL3 : MonoBehaviour
{
    public float rotationFactor;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotationFactor * timer));
    }
}
