using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookEnemy : MonoBehaviour
{
    public Transform enemy;
    Transform spPoint;

    RaycastHit hit; 
    public float lineSize = 4f;

    public Object particle;

    void Start()
    {
        // �̸����� ã��        
        //enemy = GameObject.Find("Enemy").transform;
        

        // ���� ������ �ڽ� ������Ʈ�� transform�� ã�� ���� ��
        spPoint = transform.Find("/Turret/Tower/SpawnPoint");    
    }

    // Update is called once per frame
    void Update()
    {
        // �ֽ�( ���� �������� ȸ��)
        this.transform.LookAt(enemy);

        Debug.DrawRay(spPoint.position, spPoint.forward * lineSize, Color.yellow);

        //out hit�� ������ ��´�.
        if(Physics.Raycast(spPoint.position, spPoint.forward, out hit, lineSize))
        {
            GameObject partObj = (GameObject)Instantiate(particle, hit.collider.transform);

            Debug.Log(hit.collider.gameObject.name);
            Destroy(partObj, 0.5f);
        }

    }
}
