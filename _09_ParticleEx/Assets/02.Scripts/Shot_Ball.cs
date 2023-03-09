using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot_Ball : MonoBehaviour
{
    Transform pos_tr;
    Rigidbody rb;

    public float power = 2000f;
    Vector3 velocity;
    void Start()
    {
        //tr = this.GetComponent<Transform>();
        pos_tr = GameObject.Find("FirePos").transform;
        rb = this.GetComponent<Rigidbody>();
        velocity = pos_tr.forward;
        rb.AddRelativeForce(velocity * power);
    }

    void Update()
    {
        // Ball의 높이가 바닥아래로 -10이하면
        // Ball 게임오브젝트를 삭제한다
        if (pos_tr.position.y < -10f)
        {
            Destroy(this.gameObject);
        }
    }

}
