using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour {
	public Animator animator;
    public Rigidbody2D rigidbod;
    public float playerSpeed = 6f;
    public float JumpForce = 16;
	
    void Update() {

		animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));

    	Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * playerSpeed * Time.deltaTime;

        //flip player towards walking direction
        if ((Input.GetAxis("Horizontal")) < 0) {
            this.transform.eulerAngles = new Vector2(0,180);
        }
        else if ((Input.GetAxis("Horizontal")) > 0) {
            this.transform.eulerAngles = new Vector2(0,0);
        }

        if (Input.GetButtonDown("Jump")) {
            rigidbod.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);

        }
    }
}
