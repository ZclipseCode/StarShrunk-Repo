using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int tentKilled = 0;

    private void Update()
    {
        if(tentKilled >= 5)
        {
            Debug.Log("load next");
        }
    }
}
