using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAnimation : MonoBehaviour
{
    Animation anim;
    MoveSpartan moveSpartan;

    void Start()
    {
        anim = GetComponent<Animation>();
        moveSpartan = GetComponent<MoveSpartan>();
        moveSpartan.runAnimation += RunAnim;
    }

    void RunAnim(StateAnimation.eStateAnim state, float fadeLen)
    {
        anim.CrossFade(state.ToString(), fadeLen);
    }
}
