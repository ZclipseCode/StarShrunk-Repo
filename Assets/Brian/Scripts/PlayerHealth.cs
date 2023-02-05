using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int health;

    public GameObject healthBar;

    void Start()
    {
        //healthBar.transform.position = new Vector2(.665f, 2.71f);
        //healthBar.transform.localScale = new Vector2 (1f, 1f);
    }

    void Update()
    {
        if (health <= 0)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }

        if(health == 3)
        {
            healthBar.transform.localPosition = new Vector2(.665f, 2.71f);
            healthBar.transform.localScale = new Vector2(1f, 1f);
        }

        if(health == 2)
        {
            healthBar.transform.localPosition = new Vector2(-0.6284f, 2.71f);
            healthBar.transform.localScale = new Vector2(0.6802f, 1f);
        }

        if(health == 1)
        {
            healthBar.transform.localPosition = new Vector2(-1.8571f, 2.71f);
            healthBar.transform.localScale = new Vector2(0.3764104f, 1f);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
