using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenDestroyPlay : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {     
        GetComponent<AudioSource>().Play();

        // ���� ���ӿ�����Ʈ�� ����
        Destroy(this.gameObject);
    }
}
