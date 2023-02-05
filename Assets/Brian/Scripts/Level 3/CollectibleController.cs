using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleController : MonoBehaviour
{
    int totalCollectibles;
    [SerializeField] int targetCollectibles;
    [SerializeField] GameObject goal;

    void Start()
    {
        
    }

    void Update()
    {
        if (totalCollectibles == targetCollectibles)
        {
            goal.SetActive(true);
        }
    }

    public void Collected()
    {
        totalCollectibles++;
    }
}
