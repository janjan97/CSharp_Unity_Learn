using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanimAnimator : MonoBehaviour
{
    [SerializeField]
    bool isRandom = true;
    [SerializeField]
    float minWait = 0f;
    [SerializeField]
    float maxWait = 1f;

    Animator anim;
    RandomWait randomWait;

    private void Start()
    {
        randomWait = GameObject.Find("RandomWaitManager").GetComponent<RandomWait>();
        StartCoroutine(coCheckWait());

        anim = GetComponent<Animator>();
    }

    IEnumerator coCheckWait()
    {
        while (true)
        {
            isRandom = randomWait.isRandom;
            minWait = randomWait.minWait;
            maxWait = randomWait.maxWait;
            yield return new WaitForSeconds(1f);
        }
    }

    public void doIdle()
    {
        StartCoroutine(coIdle());
    }
    IEnumerator coIdle()
    {
        float wait = 0f;
        if (isRandom)
            wait = Random.Range(minWait, maxWait);
        yield return new WaitForSeconds(wait);

        anim.SetInteger("aniStep", 0);
    }
    public void doWalk()
    {
        StartCoroutine(coWalk());
    }
    IEnumerator coWalk()
    {
        float wait = 0f;
        if (isRandom)
            wait = Random.Range(minWait, maxWait);
        yield return new WaitForSeconds(wait);

        anim.SetInteger("aniStep", 1);
    }
    public void doRun()
    {
        StartCoroutine(coRun());
    }
    IEnumerator coRun()
    {
        float wait = 0f;
        if (isRandom)
            wait = Random.Range(minWait, maxWait);
        yield return new WaitForSeconds(wait);

        anim.SetInteger("aniStep", 2);
    }
    public void doJump()
    {
        StartCoroutine(coJump());
    }

    IEnumerator coJump()
    {
        float wait = 0f;
        if (isRandom)
            wait = Random.Range(minWait, maxWait);
        yield return new WaitForSeconds(wait);

        anim.SetInteger("aniStep", 3);
        yield return new WaitForSeconds(0.8f);
        anim.SetInteger("aniStep", 0);
    }
}
