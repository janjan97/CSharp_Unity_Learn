using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOneShot : MonoBehaviour
{
    public AudioClip[] arrAudio;

    private void OnCollisionEnter(Collision collision)
    {
        // ���� �迭�� ��ϵ� �����߿� ���Ƿ� ����
        int sel = Random.Range(0, arrAudio.Length);
        AudioClip audio = arrAudio[sel];

        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().PlayOneShot(audio, 0.8f);
    }
}
