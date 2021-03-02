using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueButton : MonoBehaviour
{
    public GameObject BluePlatform;

    void OnCollisionEnter2D(Collision2D collider) {
        Debug.Log(collider.gameObject.name);
        //if collision is detected
        BluePlatform.transform.localScale = new Vector2(2,1);
    }
}
