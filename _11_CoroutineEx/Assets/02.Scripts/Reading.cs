using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reading : MonoBehaviour
{
    public float accTime = 0f;
    public float intervalTime = 1f;
    public int count = 0;

    void Update()
    {
        // 1������ ȣ��ø��� �ð� ������ ��������
        accTime += Time.deltaTime;

        // intervalTime�̻� �ð��� ������
        if (accTime > intervalTime)
        {
            Debug.Log($"å�� �д´� {count++}");
            accTime = 0f;
        }
    }
}