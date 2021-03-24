using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leg : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collider) {
        Debug.Log(collider.gameObject.name);

    }
}
