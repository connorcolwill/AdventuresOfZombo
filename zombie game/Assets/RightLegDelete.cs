using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLegDelete : MonoBehaviour
{
    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire5")) {
            this.transform.localScale = new Vector2(0,0);
        }   
}
}
