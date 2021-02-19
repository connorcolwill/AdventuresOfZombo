using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArm : MonoBehaviour {
    public float speed = 10f;
    public Rigidbody2D rigbod;

    // Start is called before the first frame update
    // throw the arm
    void Start() {
        rigbod.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D trigger) {
        Debug.Log(trigger.name);

    }


}
