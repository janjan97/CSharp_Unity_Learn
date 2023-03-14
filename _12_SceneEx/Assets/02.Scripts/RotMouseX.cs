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

        // eulerAngles�� ������ ����
        // localEuelerAngles�� �θ����� ���������� ����

        this.transform.localEulerAngles = new Vector3(0f, rotX, 0f);
    }
}
