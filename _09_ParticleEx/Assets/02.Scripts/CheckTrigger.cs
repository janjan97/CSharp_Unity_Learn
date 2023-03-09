using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTrigger : MonoBehaviour
{    

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"OnTriggerEnter - {other.name}");
    }
}
