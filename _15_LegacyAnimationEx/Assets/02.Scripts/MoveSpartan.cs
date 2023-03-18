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

    // ��������Ʈ �ڷ��� ����
    public delegate void RunAnimation(StateAnimation.eStateAnim state, float fadeLen);
    // ��������Ʈ ���� ����
    public event RunAnimation runAnimation = null;

    public delegate void PlaySound(StateAnimation.eStateAnim state);
    public event PlaySound playSound = null;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // ���� ����ֳ�?
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
                 * victory �ִϸ��̼�
                 */
                if (runAnimation != null)
                    runAnimation(StateAnimation.eStateAnim.victory, 0.2f);
                if (playSound != null)
                    playSound(StateAnimation.eStateAnim.victory);
            }
            // ������ ����(��, ��ȭ���� �ִ���)
            else if(velocity.magnitude > 0.5f)
            {
                /*
                 * run �ִϸ��̼�
                 */
                if (runAnimation != null)
                    runAnimation(StateAnimation.eStateAnim.run, 0.2f);
                if (playSound != null)
                    playSound(StateAnimation.eStateAnim.run);

                // ���� ���⿡�� ��ȭ �������� ȸ��
                this.transform.LookAt(this.transform.position + velocity);
            }
            else
            {
                /*
                 * idle �ִϸ��̼�
                 */
                if (runAnimation != null)
                    runAnimation(StateAnimation.eStateAnim.idle, 0.2f);
                if (playSound != null)
                    playSound(StateAnimation.eStateAnim.idle);
            }
        }


        // ó������ ������ ��� > õõ�� ��� > ���� > õõ�� �ϰ� > ������ �ϰ�
        velocity.y -= gravity * Time.deltaTime;

        // velocity�� ���� Ŀ�� �� �۰� ����� ���� �ٽ� Time.deltaTime�� ������
        controller.Move(velocity * Time.deltaTime);
    }
}
