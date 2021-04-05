using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gravestone : MonoBehaviour
{
    public string nextLevel;
    void OnCollisionEnter2D(Collision2D collider) {
        SceneManager.LoadScene(nextLevel);
    }
}
