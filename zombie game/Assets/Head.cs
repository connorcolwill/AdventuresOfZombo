using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rigbod;

    // Start is called before the first frame update
    // throw the head
    //void Start() {
        //not used for now
       // rigbod.velocity = transform.right * speed;
    //}

    void OnCollisionEnter2D(Collision2D collider) {
        Debug.Log(collider.gameObject.name);

    }
}
