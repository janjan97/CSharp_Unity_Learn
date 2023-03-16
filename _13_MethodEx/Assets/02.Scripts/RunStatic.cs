using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunStatic : MonoBehaviour
{    
    void Start()
    {
        // static은 클래스이름으로 바로 호출할 수 있다.
        Debug.Log($"RotateBox.numX  = {RotateBox.numX}");
        Debug.Log($"RotateBox.AddTwoNum(3, 5) = {RotateBox.AddTwoNum(3, 5)}");
    }
    
}
