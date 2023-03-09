using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Transform tr;
    public float speed = 10f;

    private void Start()
    {
        tr = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        tr.Translate(Vector3.right * h);
        tr.Translate(Vector3.forward * v);
    }
}
