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
                rb.isKinematic = false; // (üũ����) ����� �� �������� ��� on
                rb.AddRelativeForce(new Vector3(0f, 200f, -200f)); // �� 45������ ���� ����
                

                // other���ϸ� ���ȿ� �����ȴ�
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
                rb.isKinematic = true; // �ٴڿ� ����� �� �������� ��� off
                break;
        }
    }
}
