using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour {
	public Animator animator;
    public float JumpForce = 1f;

    private Rigidbody2D _rigidbody;    
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    	animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));
    	Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * 6 * Time.deltaTime;

        //flip player towards walking direction
        if ((Input.GetAxis("Horizontal")) < 0) {
            this.transform.eulerAngles = new Vector2(0,180);
        }
        else if ((Input.GetAxis("Horizontal")) > 0) {
            this.transform.eulerAngles = new Vector2(0,0);
        }

        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }   
    }
}


