using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 800f;
    public float rotX = 0;
    public float rotY = 0;
    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotX += mouseX * sensitivity * Time.deltaTime;
        rotY += mouseY * sensitivity * Time.deltaTime;

        // 고개 들어서90도까지
        if (rotY > 90f)
            rotY = 90f;

        if (rotY < -20f) // 고개 숙여 -20도까지
            rotY = -20f;

        this.transform.eulerAngles = new Vector3(-rotY, rotX, 0f);
    }
}
