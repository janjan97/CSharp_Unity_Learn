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
        // 이름으로 찾기        
        //enemy = GameObject.Find("Enemy").transform;
        

        // 계층 구조로 자식 오브젝트의 transform을 찾고 싶을 때
        spPoint = transform.Find("/Turret/Tower/SpawnPoint");    
    }

    // Update is called once per frame
    void Update()
    {
        // 주시( 적의 방향으로 회전)
        this.transform.LookAt(enemy);

        Debug.DrawRay(spPoint.position, spPoint.forward * lineSize, Color.yellow);

        //out hit에 정보를 담는다.
        if(Physics.Raycast(spPoint.position, spPoint.forward, out hit, lineSize))
        {
            GameObject partObj = (GameObject)Instantiate(particle, hit.collider.transform);

            Debug.Log(hit.collider.gameObject.name);
            Destroy(partObj, 0.5f);
        }

    }
}
