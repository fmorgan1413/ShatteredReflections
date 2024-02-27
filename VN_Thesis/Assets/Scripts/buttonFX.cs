using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonFX : MonoBehaviour
{
    public AudioSource fx;
    public AudioClip hoverFX;

    public void HoverSound()
    {
        fx.PlayOneShot(hoverFX);
    }
}
