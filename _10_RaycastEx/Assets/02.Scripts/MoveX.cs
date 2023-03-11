using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveX : MonoBehaviour
{
    public float speed = 50f;
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        h = h * speed * Time.deltaTime;

        
        this.transform.Translate(Vector3.right * h);
    }

    
}
