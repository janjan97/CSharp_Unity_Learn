using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZ : MonoBehaviour
{
    Transform tr;
    public float speed = 100f;

    private void Start()
    {
            tr = GetComponent<Transform>();
    }

    
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        
        v = v * speed * Time.deltaTime;
        tr.Translate(Vector3.forward * v);
    }
}
