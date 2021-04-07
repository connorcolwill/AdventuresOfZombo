using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.name == "LeftArm(Clone)")
        {
            Debug.Log(collider.gameObject.name);
            Destroy(this.gameObject);
        }
    }
}
