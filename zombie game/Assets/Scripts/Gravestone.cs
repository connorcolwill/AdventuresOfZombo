using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravestone : MonoBehaviour
{
    public GameObject levelCompleteScreen;

    public void OnCollisionEnter2D(Collision2D collider)
    {
        levelCompleteScreen.SetActive(true);
    }
}
