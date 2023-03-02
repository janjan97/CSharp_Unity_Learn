using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCMove : MonoBehaviour
{
    public float movSpeed = 20f;
    public float rotSpeed = 400f;

    Transform tr;
    CharacterController controller;
    Vector3 moveDirection;

    public float jumpSpeed = 10f;
    public float gravity = 20f;

    
    void Start()
    {
        tr = GetComponent<Transform>();
        controller = GetComponent<CharacterController>();    
    }

    
    void Update()
    {
        // 회전은 Transform의 기능을 사용한다.
        float h = Input.GetAxis("Horizontal");

        //tr.Rotate(Vector3.up * h * rotSpeed * Time.deltaTime);
        h = h * rotSpeed * Time.deltaTime;
        tr.Rotate(Vector3.up * h);

        if (controller.isGrounded)
        {
            float v = Input.GetAxis("Vertical");
           

            // 이동 방향을 로컬 좌표에서
            moveDirection = new Vector3(0f, 0f, v * movSpeed);
            // 절대 좌표로 변경한다 (CharacterController는 절대좌표로 이동한다)
            moveDirection = tr.TransformDirection(moveDirection);

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
