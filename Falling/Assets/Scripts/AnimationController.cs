
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animation anim;
    public MoveToScene mts;


    public void StartFade()
    {
        StartCoroutine(Fade());
        Fade();
    }

    public IEnumerator Fade()
    {
  
        anim.Play("FadeIn");
        yield return new WaitForSeconds(0.833f);
        mts.ToScene();
    }
}
