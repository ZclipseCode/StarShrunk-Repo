using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    static MusicManager instance;
    AudioSource audioSource;

    [SerializeField] string title;
    [SerializeField] string lvl1;
    [SerializeField] string lvl2;
    [SerializeField] string lvl3;
    [SerializeField] string boss;
    [SerializeField] string win;

    [SerializeField] AudioClip titleAC;
    [SerializeField] AudioClip lvl1AC;
    [SerializeField] AudioClip lvl2AC;
    [SerializeField] AudioClip lvl3AC;
    [SerializeField] AudioClip bossAC;
    [SerializeField] AudioClip winAC;

    Scene scene;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        scene = SceneManager.GetActiveScene();

        if (scene.name == title)
        {
            audioSource.PlayOneShot(titleAC);
        }
        else if (scene.name == lvl2)
        {
            audioSource.PlayOneShot(lvl2AC);
        }
        else if (scene.name == lvl3)
        {
            audioSource.PlayOneShot(lvl3AC);
        }
        else if (scene.name == boss)
        {
            audioSource.PlayOneShot(bossAC);
        }
        else if (scene.name == win)
        {
            audioSource.PlayOneShot(winAC);
        }
    }
}
