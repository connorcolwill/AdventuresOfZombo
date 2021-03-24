using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rigbod;

    // detect collisions with other game objects
    void OnCollisionEnter2D(Collision2D collider) {
        Debug.Log(collider.gameObject.name);
    

    }
}
