using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource PointerOn;

    public void Effect()
    {
        PointerOn.Play();
    }
    
}
