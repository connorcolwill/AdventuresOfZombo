using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detach : MonoBehaviour
{
    public Transform detachPoint;
    public GameObject leftArmPrefab;
    public GameObject headPrefab;
    public GameObject legPrefab;
    public int leftArmUsed;
    public int rightArmUsed;
    public int headUsed;
    public int leftLegUsed;
    public int rightLegUsed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            if (leftArmUsed < 1) {
                ThrowLeftArm();
            }
        }
        else if (Input.GetButtonDown("Fire2")) {
            if (rightArmUsed < 1) {
                ThrowRightArm();
            }
        }
        else if (Input.GetButtonDown("Fire3")) {
            if (headUsed < 1) {
                ThrowHead();
            }
        }
        else if (Input.GetButtonDown("Fire4")) {
            if (leftLegUsed < 1) {
                ThrowLeftLeg();
            }
        }
        else if (Input.GetButtonDown("Fire5")) {
            if (rightLegUsed < 1) {
                ThrowRightLeg();
            }
        }
    }

    void ThrowLeftArm() {
        leftArmUsed += 1;
        Instantiate(leftArmPrefab, detachPoint.position, detachPoint.rotation);
    }
    void ThrowRightArm() {
        rightArmUsed += 1;
        Instantiate(leftArmPrefab, detachPoint.position, detachPoint.rotation);
    }
    void ThrowHead() {
        headUsed += 1;
        Instantiate(headPrefab, detachPoint.position, detachPoint.rotation);
    }
    void ThrowLeftLeg() {
        leftLegUsed += 1;
        Instantiate(legPrefab, detachPoint.position, detachPoint.rotation);
    }
    void ThrowRightLeg() {
        rightLegUsed += 1;
        Instantiate(legPrefab, detachPoint.position, detachPoint.rotation);
    }
}
