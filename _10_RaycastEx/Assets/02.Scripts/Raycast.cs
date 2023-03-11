using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public float lineSize = 16f;

    // Update is called once per frame
    void Update()
    {
        // Gameȭ�鿡�� �������ʴ´�
        // Sceneȭ�鿡�� ���δ�
        // �ش� ��ġ����, Ư�� �������� ���̸�ŭ, yellow��������
        // ������ ������ Ȯ��
        Debug.DrawRay(transform.position, transform.forward * lineSize, Color.yellow);


        //��ü�� ������ true�� ��ȯ
        // ����� 1���� ������Ʈ�� �����Ѵ�.
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, lineSize))
        {

            // ���� ��ü�� �̸��� ���
            Debug.Log(hit.collider.gameObject.name);
        }
    }
}
