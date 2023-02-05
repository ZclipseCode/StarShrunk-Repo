using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int tentKilled = 0, eyeKilled = 0, lumpEaten = 0;
    private void Start() {
        tentKilled = 0;
        eyeKilled = 0;
        lumpEaten = 0;
    }

    private void Update()
    {
        if(tentKilled >= 5)
        {
            Debug.Log("load next");
            tentKilled = 0;
            SceneManager.LoadScene("Ethan Boss Stage 2");
        }
        if(eyeKilled >= 3) {
            Debug.Log("load next");
            eyeKilled = 0;
            SceneManager.LoadScene("Ethan Boss Stage 3");
        }
        if(lumpEaten >= 4) {
            lumpEaten = 0;
            SceneManager.LoadScene("Win Scene");
        }
    }
}
