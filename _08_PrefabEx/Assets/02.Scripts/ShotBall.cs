using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBall : MonoBehaviour
{
    Transform tr;
    Rigidbody rb;

    public float power = 900f;
    Vector3 velocity;
    void Start()
    {
        tr = this.GetComponent<Transform>(); 
        rb = this.GetComponent<Rigidbody>();
        velocity = tr.forward;
        rb.AddRelativeForce(velocity * power);
    }
    
    void Update()
    {
        // Ball의 높이가 바닥아래로 -10이하면
        // Ball 게임오브젝트를 삭제한다
        if(tr.position.y < -10f)
        {
            Destroy(this.gameObject);
        }
    }
}
