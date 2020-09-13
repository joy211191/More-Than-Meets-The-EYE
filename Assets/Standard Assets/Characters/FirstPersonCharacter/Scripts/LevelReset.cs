using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelReset : MonoBehaviour {
    private void OnTriggerEnter (Collider other) {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
