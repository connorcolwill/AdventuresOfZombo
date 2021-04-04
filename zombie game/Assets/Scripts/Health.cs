using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int lives;
    public int numHearts;
    public Image[] hearts;
    public Rigidbody2D rigidbod;
    public Animator animator;
    int damageDelay = 1;
    float timer;

    void Start()
    {
        timer = damageDelay;
    }
    void Update() {
        timer -= Time.deltaTime;
        if (rigidbod.position.y < -5f) //player fell down
        {
            lives = 0;
        }
        if (lives < 1)
        {
            //player died
            lives = numHearts;
            GameManager.instance.RestartLevel();
        }
        if (lives > numHearts){
            lives = numHearts;
        }
        for(int i = 0; i < hearts.Length; i++){
            if (i < numHearts) {
                hearts[i].enabled = true;
            }
            else {
                hearts[i].enabled = false;
            }
            if (i >= lives) {
                hearts[i].enabled = false;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collider) {
        if (timer <= 0)
        {
            if (collider.gameObject.CompareTag("Enemy") || collider.gameObject.CompareTag("Trap"))
            {
                PlayerTakesDamage(1);
                timer = damageDelay;
            }
        }
    }

    public void PlayerTakesDamage(int life) {
        animator.SetTrigger("Damage");
        lives = lives - life;
    }
}
