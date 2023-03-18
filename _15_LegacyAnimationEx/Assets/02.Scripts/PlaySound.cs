using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField]
    private AudioClip idleClip;
    [SerializeField]
    private AudioClip runClip;
    [SerializeField]
    private AudioClip victoryClip;
    MoveSpartan moveSpartan;

    StateAnimation.eStateAnim preState = StateAnimation.eStateAnim.none;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        moveSpartan = GetComponent<MoveSpartan>();
        moveSpartan.playSound += MoveSpartan_playSound;
    }

    private void MoveSpartan_playSound(StateAnimation.eStateAnim state)
    {
        if (preState == state)
            return;

        audioSource.Stop();

        switch (state)
        {
            case StateAnimation.eStateAnim.idle:
                Debug.Log("Sound idle");                
                audioSource.PlayOneShot(idleClip);
                break;
            case StateAnimation.eStateAnim.run:
                Debug.Log("Sound run");
                 audioSource.PlayOneShot(runClip);
                break;
            case StateAnimation.eStateAnim.victory:
                Debug.Log("Sound victory");
                audioSource.PlayOneShot(victoryClip);
                break;
        }

        preState = state;
    }
}
