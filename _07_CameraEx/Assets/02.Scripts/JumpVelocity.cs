using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpVelocity : MonoBehaviour
{
        
    void Update()
    {
        // space ��ư
        if (Input.GetButtonDown("Fire1"))
        {
            // y������ 10 �ӵ��� �ο��Ѵ�.
            this.GetComponent<Rigidbody>().velocity = new Vector3(0f, 10f, 0f);
        }
    }
}
