using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioManager : MonoBehaviour
{
    GameObject audioManager;
    AudioSource yourAudio;
    void Start()
    {
        audioManager = GameObject.Find("AudioManager");
        yourAudio = audioManager.GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        yourAudio.Play();
        Destroy(this.gameObject);
    }
}
