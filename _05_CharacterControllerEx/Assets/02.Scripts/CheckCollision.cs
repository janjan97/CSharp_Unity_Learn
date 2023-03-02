using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"OnCollisionEnter - {collision.collider.name}");
    }
    
    // CharacterController에서 IsTrigger를 설정하면 OnTriggerEnter가 발생하게 된다.
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"OnTriggerEnter - {other.name}");
    }

    // CharacterController의 이벤트
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // if (hit.collider.tag.Equals("WALL"))
        // if (hit.collider.CompareTag("WALL"))
        if (hit.collider.tag == "WALL")
            Debug.Log($"OnControllerColliderHit - {hit.collider.name}");
    }

}
