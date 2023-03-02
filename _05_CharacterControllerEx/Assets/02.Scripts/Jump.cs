using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    Transform tr;
    CharacterController controller;
    float gravity = -20f;
    float jumpSpeed = 10f;
    Vector3 velocity = new Vector3(0f, 0f, 0f);
    float firstY;
    bool isJump = false;
    void Start()
    {
        tr = GetComponent<Transform>();
        controller = GetComponent<CharacterController>();
        firstY = tr.position.y;
    }    
    void Update()
    {
        // ĳ���Ͱ� ���� ����ִ���
        //if(controller.isGrounded)
        {
            if(Input.GetButtonDown("Jump")) 
            {
                velocity.y = jumpSpeed;
                isJump= true;
            }
            if (isJump)
            {
                velocity.y += (gravity * Time.deltaTime); //���

                // ĳ���� ��Ʈ�ѷ� ������Ʈ�� ����ؼ� ��ġ �̵��� �� ���
                controller.Move(velocity * Time.deltaTime); // �ϰ�

                if(tr.position.y < firstY)
                {
                    Vector3 pos = new Vector3(tr.position.x, firstY+0.1f, tr.position.z);
                    tr.position = pos;
                    
                    isJump = false;
                }
            }
        }
    }
}
