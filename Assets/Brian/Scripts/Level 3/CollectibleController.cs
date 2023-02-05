using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectibleController : MonoBehaviour
{
    int totalCollectibles;
    [SerializeField] int targetCollectibles;
    [SerializeField] string bossSceneName;

    void Start()
    {
        
    }

    void Update()
    {
        if (totalCollectibles == targetCollectibles)
        {
            SceneManager.LoadScene(bossSceneName);
        }
    }

    public void Collected()
    {
        totalCollectibles++;
    }
}
