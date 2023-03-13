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
        // 1프레임 호출시마다 시간 간격을 누적저장
        accTime += Time.deltaTime;

        // intervalTime이상 시간이 지나면
        if (accTime > intervalTime)
        {
            Debug.Log($"책을 읽는다 {count++}");
            accTime = 0f;
        }
    }
}
