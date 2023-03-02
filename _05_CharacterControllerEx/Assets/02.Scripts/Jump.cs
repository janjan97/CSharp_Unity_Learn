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
        // 캐릭터가 땅에 닿아있는지
        //if(controller.isGrounded)
        {
            if(Input.GetButtonDown("Jump")) 
            {
                velocity.y = jumpSpeed;
                isJump= true;
            }
            if (isJump)
            {
                velocity.y += (gravity * Time.deltaTime); //상승

                // 캐릭터 컨트롤러 컴포넌트를 사용해서 위치 이동할 때 사용
                controller.Move(velocity * Time.deltaTime); // 하강

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
