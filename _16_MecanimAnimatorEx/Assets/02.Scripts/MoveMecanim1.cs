using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMecanim1 : MonoBehaviour
{
    public float movSpeed = 2f;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        float speed = Input.GetAxis("Vertical");

        anim.SetFloat("direction", direction);

        // 양수/음수든 WalkForward상태로 전이하기 위해 절대값을 넣어줌
        anim.SetFloat("speed", Mathf.Abs(speed));

        // 후진까지 하려고 넣어줌
        this.transform.Translate(Vector3.forward * speed * movSpeed * Time.deltaTime);
    }
}
