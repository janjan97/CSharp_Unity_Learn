using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpartan : MonoBehaviour
{
    public float walkSpeed = 8.0f;
    public float gravity = 20f;
    public float jumpSpeed = 12f;
    Vector3 velocity;
    CharacterController controller;

    // 델리게이트 자료형 선언
    public delegate void RunAnimation(StateAnimation.eStateAnim state, float fadeLen);
    // 델리게이트 변수 선언
    public event RunAnimation runAnimation = null;

    public delegate void PlaySound(StateAnimation.eStateAnim state);
    public event PlaySound playSound = null;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // 땅에 닿아있나?
        if (controller.isGrounded)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            velocity = new Vector3(h, 0, v);
            velocity *= walkSpeed;

            if (Input.GetButton("Jump"))
            {               
                velocity.y = jumpSpeed;

                Debug.Log($"****** velocity.y = {velocity.y}");
                /*
                 * victory 애니메이션
                 */
                if (runAnimation != null)
                    runAnimation(StateAnimation.eStateAnim.victory, 0.2f);
                if (playSound != null)
                    playSound(StateAnimation.eStateAnim.victory);
            }
            // 벡터의 길이(즉, 변화값이 있느냐)
            else if(velocity.magnitude > 0.5f)
            {
                /*
                 * run 애니메이션
                 */
                if (runAnimation != null)
                    runAnimation(StateAnimation.eStateAnim.run, 0.2f);
                if (playSound != null)
                    playSound(StateAnimation.eStateAnim.run);

                // 현재 방향에서 변화 방향으로 회전
                this.transform.LookAt(this.transform.position + velocity);
            }
            else
            {
                /*
                 * idle 애니메이션
                 */
                if (runAnimation != null)
                    runAnimation(StateAnimation.eStateAnim.idle, 0.2f);
                if (playSound != null)
                    playSound(StateAnimation.eStateAnim.idle);
            }
        }


        // 처음에는 빠르게 상승 > 천천히 상승 > 멈춤 > 천천히 하강 > 빠르게 하강
        velocity.y -= gravity * Time.deltaTime;

        // velocity의 값이 커서 더 작게 만들기 위해 다시 Time.deltaTime을 곱해줌
        controller.Move(velocity * Time.deltaTime);
    }
}
