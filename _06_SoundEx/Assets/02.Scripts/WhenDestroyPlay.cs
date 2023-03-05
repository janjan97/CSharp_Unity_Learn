using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenDestroyPlay : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {     
        GetComponent<AudioSource>().Play();

        // 현재 게임오브젝트를 제거
        Destroy(this.gameObject);
    }
}
