using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunStatic : MonoBehaviour
{    
    void Start()
    {
        // static�� Ŭ�����̸����� �ٷ� ȣ���� �� �ִ�.
        Debug.Log($"RotateBox.numX  = {RotateBox.numX}");
        Debug.Log($"RotateBox.AddTwoNum(3, 5) = {RotateBox.AddTwoNum(3, 5)}");
    }
    
}
