﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject Platform1;
    public Collider2D plateCollider;
    public Collider2D playerFootCollider;
    public CircleCollider2D playerBodyCollider;

    void Update ()
    {
        GameObject[] legs = GameObject.FindGameObjectsWithTag("Leg");
        foreach(GameObject leg in legs)
        {
            if (leg.GetComponent<Collider2D>().IsTouching(plateCollider) || playerFootCollider.IsTouching(plateCollider) || playerBodyCollider.IsTouching(plateCollider))
            {
                Platform1.transform.localScale = new Vector3(9, 1, 1);
            }
            else
            {
                Platform1.transform.localScale = new Vector3(0, 0, 1);
            }
        }
    }
}
