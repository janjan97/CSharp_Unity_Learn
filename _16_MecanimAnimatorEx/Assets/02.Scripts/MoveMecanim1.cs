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

        // ���/������ WalkForward���·� �����ϱ� ���� ���밪�� �־���
        anim.SetFloat("speed", Mathf.Abs(speed));

        // �������� �Ϸ��� �־���
        this.transform.Translate(Vector3.forward * speed * movSpeed * Time.deltaTime);
    }
}
