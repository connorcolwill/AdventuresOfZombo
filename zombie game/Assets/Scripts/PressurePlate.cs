using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject Platform1;
    public Collider2D plateCollider;
    //public Collider2D playerBodyCollider;
    public CircleCollider2D playerFootCollider;

    void Update ()
    {
        if (playerFootCollider.IsTouching(plateCollider))
        {
            if (Platform1.CompareTag("BluePlatform")) {
                Platform1.transform.localScale = new Vector3(1, 1, 1);
            }
            else
            {
                Platform1.transform.localScale = new Vector3(9, 1, 1);
            }
        }
        else
        {
            Platform1.transform.localScale = new Vector3(0, 0, 1);
        }

        //if leg object exists in the scene these statements are called
        GameObject[] legs = GameObject.FindGameObjectsWithTag("Leg");
        foreach (GameObject leg in legs)
        {
            if (leg.GetComponent<Collider2D>().IsTouching(plateCollider) || playerFootCollider.IsTouching(plateCollider))
            {
                if (Platform1.CompareTag("BluePlatform")) {
                    Platform1.transform.localScale = new Vector3(1, 1, 1);
                }
                else
                {
                    Platform1.transform.localScale = new Vector3(9, 1, 1);
                }
            }
            else
            {
                Platform1.transform.localScale = new Vector3(0, 0, 1);
            }
        }
    }
        
}
