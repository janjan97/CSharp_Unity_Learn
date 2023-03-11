using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastAll : MonoBehaviour
{
    public float lineSize = 16f;

    // Update is called once per frame
    void Update()
    {
        // 눈에 보이는 선을 그린다 ( 다른 작용은 없음)
        Debug.DrawRay(transform.position, transform.forward * lineSize, Color.yellow);

        // 선에 닿는 모든 오브젝트 정보를 배열에 저장한다.
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, lineSize);

        for (int i = 0; i<hits.Length; i++)
        {
            RaycastHit hit = hits[i];
            Debug.Log(hit.collider.gameObject.name);
        }
    }
}
