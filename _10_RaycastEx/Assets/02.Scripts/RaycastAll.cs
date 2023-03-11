using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastAll : MonoBehaviour
{
    public float lineSize = 16f;

    // Update is called once per frame
    void Update()
    {
        // ���� ���̴� ���� �׸��� ( �ٸ� �ۿ��� ����)
        Debug.DrawRay(transform.position, transform.forward * lineSize, Color.yellow);

        // ���� ��� ��� ������Ʈ ������ �迭�� �����Ѵ�.
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, lineSize);

        for (int i = 0; i<hits.Length; i++)
        {
            RaycastHit hit = hits[i];
            Debug.Log(hit.collider.gameObject.name);
        }
    }
}
