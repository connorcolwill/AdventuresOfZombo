using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource audsource;

    private void Awake()
    {
        audsource = GetComponent<AudioSource>();
    }

    private void DeathSound()
    {
        audsource.PlayOneShot(clip);
    }
}
