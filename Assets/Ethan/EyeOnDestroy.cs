using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeOnDestroy : MonoBehaviour{
    private void OnDestroy() {
        GameManager.eyeKilled++;
    }
}
