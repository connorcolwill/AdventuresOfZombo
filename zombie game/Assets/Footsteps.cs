using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource audsource;

    private void Awake()
    {
        audsource = GetComponent<AudioSource>();
    }

    private void FootstepSound()
    {
        audsource.PlayOneShot(clip);
    }
}
