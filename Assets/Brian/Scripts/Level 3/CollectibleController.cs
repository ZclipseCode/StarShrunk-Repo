using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectibleController : MonoBehaviour
{
    int totalCollectibles;
    [SerializeField] int targetCollectibles;
    [SerializeField] string bossScene;

    void Start()
    {
        
    }

    void Update()
    {
        if (totalCollectibles == targetCollectibles)
        {
            SceneManager.LoadScene(bossScene);
        }
    }

    public void Collected()
    {
        totalCollectibles++;
    }
}
