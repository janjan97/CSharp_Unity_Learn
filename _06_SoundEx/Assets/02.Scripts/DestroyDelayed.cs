using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDelayed : MonoBehaviour
{
    AudioSource myaudio;
    private void Start()
    {
        myaudio = this.GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        myaudio.Play();

        // 음원의 시간만큼 기다렸다가 현재 게임오브젝트를 삭제한다.
        Destroy(this.gameObject, myaudio.clip.length);
    }
}
