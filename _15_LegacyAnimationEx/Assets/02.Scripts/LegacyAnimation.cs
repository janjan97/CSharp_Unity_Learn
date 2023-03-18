using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LegacyAnimation : MonoBehaviour
{
    Animation anim;
    AudioSource audioSource;
    public AudioClip attackSound;
    public AudioClip victorySound;
    public AudioClip saluteSound;

    void Start()
    {
        anim = this.GetComponent<Animation>();
        this.AddComponent<AudioSource>();
        audioSource = this.GetComponent<AudioSource>();
    }

    public void doIdle()
    {
        //anim.Play("idle");
        anim.CrossFade("idle", 0.2f);
    }

    public void doWalk()
    {
        anim["walk"].wrapMode = WrapMode.Loop;
        anim.CrossFade("walk", 0.2f);
    }

    public void doRun()
    {
        StartCoroutine(coRun());
    }

    IEnumerator coRun()
    {
        anim["run"].wrapMode = WrapMode.Loop;
        anim.CrossFade("run", 0.2f);
        yield return new WaitForSeconds(3f);
        anim["run"].speed = 2f;
        yield return new WaitForSeconds(3f);
        anim["run"].speed = 4f;
        yield return new WaitForSeconds(3f);
        anim["run"].speed = 1f;
    }

    public void doAttack()
    {
        audioSource.PlayOneShot(attackSound);
        anim.CrossFade("attack", 0.2f);
    }

    public void doVictory()
    {
        StartCoroutine(coVictory());
    }

    IEnumerator coVictory()
    {
        audioSource.PlayOneShot(victorySound);
        anim.CrossFade("victory", 0.2f);
        float len = anim["victory"].length;
        yield return new WaitForSeconds(len - 0.1f);
        audioSource.PlayOneShot(saluteSound);
        anim.CrossFade("salute", 0.2f);
        len = anim["salute"].length;
        yield return new WaitForSeconds(len - 0.1f);
        anim.CrossFade("idle", 0.2f);
    }
}
