using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Transform tr;
    public float movSpeed = 100f;
    public float rotSpeed = 200f;

    void Start()
    {
        tr = this.GetComponent<Transform>();    
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * rotSpeed * Time.deltaTime;
        v = v * movSpeed * Time.deltaTime;

        tr.Translate(Vector3.forward * v);
        tr.Rotate(Vector3.up * h);
    }
}
