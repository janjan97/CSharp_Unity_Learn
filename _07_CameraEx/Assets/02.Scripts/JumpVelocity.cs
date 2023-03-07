using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpVelocity : MonoBehaviour
{
        
    void Update()
    {
        // space 버튼
        if (Input.GetButtonDown("Fire1"))
        {
            // y축으로 10 속도를 부여한다.
            this.GetComponent<Rigidbody>().velocity = new Vector3(0f, 10f, 0f);
        }
    }
}
