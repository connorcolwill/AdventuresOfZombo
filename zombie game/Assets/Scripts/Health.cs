using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int lives;
    public int numHearts;
    public Image[] hearts;

    void Update() {
        if (lives < 1) {
            print("player is dead");
            Destroy(gameObject);
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
        if (collider.gameObject.CompareTag("Enemy")){
            PlayerTakesDamage(1);
        }
    }

    public void PlayerTakesDamage(int life) {
        lives = lives - life;
    }
}
