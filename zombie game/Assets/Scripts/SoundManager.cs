using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip footstepSound, hurtSound;
    static AudioSource audsource;
    // Start is called before the first frame update
    void Start()
    {
        footstepSound = Resources.Load<AudioClip>("footsteps");
        hurtSound = Resources.Load<AudioClip>("hurt");
        audsource = GetComponent<AudioSource>();
        
    }


    public static void SoundEffect(string noise)
    {
        if (noise == "footsteps") {
            audsource.PlayOneShot(footstepSound);
        }
        if (noise == "hurt") {
            audsource.PlayOneShot(hurtSound);
        }
    }
}
