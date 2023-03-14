using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotMouseX : MonoBehaviour
{
    public float sensitivity = 500f;
    public float rotX = 0f;

    void Update()
    {
        float mouseMoveX = Input.GetAxis("Mouse X");

        rotX += mouseMoveX * sensitivity * Time.deltaTime;

        if (rotX < -25f)
            rotX = -25f;
        if (rotX > 25f)
            rotX = 25f;

        // eulerAngles는 절대축 기준
        // localEuelerAngles는 부모축을 절대축으로 기준

        this.transform.localEulerAngles = new Vector3(0f, rotX, 0f);
    }
}
