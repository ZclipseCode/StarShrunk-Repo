using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeKill : MonoBehaviour{
    public static bool isDashing = false;
    private void OnCollisionEnter2D(Collision2D obj) {
        if (isDashing) {
            Destroy(gameObject);
        }
    }
}
