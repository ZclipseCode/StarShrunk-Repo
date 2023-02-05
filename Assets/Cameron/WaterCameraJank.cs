using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCameraJank : MonoBehaviour
{
    public GameObject cameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.CompareTag("Player"))
        {
            Debug.Log("Player entered circle");
            cameraPosition.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D obj)
    {
        if (obj.CompareTag("Player"))
        {
            Debug.Log("Player left circle");
            cameraPosition.SetActive(false);
        }
    }
}
