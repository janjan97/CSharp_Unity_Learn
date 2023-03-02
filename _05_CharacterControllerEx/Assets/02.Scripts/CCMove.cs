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
        // ȸ���� Transform�� ����� ����Ѵ�.
        float h = Input.GetAxis("Horizontal");

        //tr.Rotate(Vector3.up * h * rotSpeed * Time.deltaTime);
        h = h * rotSpeed * Time.deltaTime;
        tr.Rotate(Vector3.up * h);

        if (controller.isGrounded)
        {
            float v = Input.GetAxis("Vertical");
           

            // �̵� ������ ���� ��ǥ����
            moveDirection = new Vector3(0f, 0f, v * movSpeed);
            // ���� ��ǥ�� �����Ѵ� (CharacterController�� ������ǥ�� �̵��Ѵ�)
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
