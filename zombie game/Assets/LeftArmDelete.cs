using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArmDelete : MonoBehaviour
{
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            this.transform.localScale = new Vector2(0,0);
    }
}
}
