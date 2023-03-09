using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerKinematic : MonoBehaviour
{
    Rigidbody rb;
    public Object particle;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"OnTriggerEnter - {other.name}");

        switch (other.name)
        {
            case "Wall":
                rb.isKinematic = false; // (체크해제) 닿았을 때 물리엔진 기능 on
                rb.AddRelativeForce(new Vector3(0f, 200f, -200f)); // 뒤 45각도로 힘을 가함
                

                // other로하면 벽안에 생성된다
                //GameObject partObj =
                //    (GameObject)Instantiate(particle,
                //                other.transform.position, other.transform.rotation);
                GameObject partObj =
                    (GameObject)Instantiate(particle,
                                this.transform.position, other.transform.rotation);
                Destroy(partObj, 0.5f);

                break;
            
        }
              
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"OnCollisionEnter - {collision.collider.name}");

        switch (collision.collider.name)
        {
            case "Floor":
                rb.isKinematic = true; // 바닥에 닿았을 때 물리엔진 기능 off
                break;
        }
    }
}
