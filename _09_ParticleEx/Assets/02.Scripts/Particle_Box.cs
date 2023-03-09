using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Box : MonoBehaviour
{
    Rigidbody rb;
    Transform tr;
    public Object particle;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        tr = this.GetComponent<Transform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"OnTriggerEnter - {other.name}");

        if (tr.position.y < -5f)
        {
           
                rb.isKinematic = false; // (üũ����) ����� �� �������� ��� on
                rb.AddRelativeForce(new Vector3(0f, 200f,0f)); //

                // other���ϸ� ���ȿ� �����ȴ�
                //GameObject partObj =
                //    (GameObject)Instantiate(particle,
                //                other.transform.position, other.transform.rotation);
                GameObject partObj =
                    (GameObject)Instantiate(particle,
                                this.transform.position, other.transform.rotation);
                Destroy(partObj, 2f);
        }

    }

   

}
