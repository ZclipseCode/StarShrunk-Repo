using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInSeconds : MonoBehaviour
{

    [SerializeField] private float secondsToDestroy = 1f;
    [SerializeField] private GameObject itemToDestroy;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(itemToDestroy, secondsToDestroy);
    }

}
