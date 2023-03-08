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
        // Ball�� ���̰� �ٴھƷ��� -10���ϸ�
        // Ball ���ӿ�����Ʈ�� �����Ѵ�
        if(tr.position.y < -10f)
        {
            Destroy(this.gameObject);
        }
    }
}
