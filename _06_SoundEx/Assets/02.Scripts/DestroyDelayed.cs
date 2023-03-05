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

        // ������ �ð���ŭ ��ٷȴٰ� ���� ���ӿ�����Ʈ�� �����Ѵ�.
        Destroy(this.gameObject, myaudio.clip.length);
    }
}
