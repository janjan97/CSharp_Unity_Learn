using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMecanim : MonoBehaviour
{
    Animator anim;
    public float movSpeed = 3f;
    public float rotSpeed = 36f;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        float speed = Input.GetAxis("Vertical");

        anim.SetFloat("direction", direction);
        //anim.SetFloat("speed", speed);
        if (speed != 0)
            anim.SetBool("isWalk", true);
        else
            anim.SetBool("isWalk", false);

        this.transform.Translate(Vector3.forward * speed * movSpeed * Time.deltaTime);
        this.transform.Rotate(Vector3.up * direction * rotSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
            StartCoroutine(coJump());
    }

    IEnumerator coJump()
    {
        anim.SetTrigger("jump");
        yield return new WaitForSeconds(0.8f);
    }
}
