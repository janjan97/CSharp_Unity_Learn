using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBox : MonoBehaviour
{
    public static int numX = 0;

    public static int AddTwoNum(int x, int y)   // static
    {
        return x + y;
    }

    public void Rotate1()                       // public
    {
        this.transform.Rotate(Vector3.up * 90f);
    }

    private void Rotate2()                      // private
    {
        this.transform.Rotate(Vector3.up * -90f);
    }
}
