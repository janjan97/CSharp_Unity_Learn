using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"OnCollisionEnter - {collision.collider.name}");
    }
    
    // CharacterController���� IsTrigger�� �����ϸ� OnTriggerEnter�� �߻��ϰ� �ȴ�.
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"OnTriggerEnter - {other.name}");
    }

    // CharacterController�� �̺�Ʈ
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // if (hit.collider.tag.Equals("WALL"))
        // if (hit.collider.CompareTag("WALL"))
        if (hit.collider.tag == "WALL")
            Debug.Log($"OnControllerColliderHit - {hit.collider.name}");
    }

}
