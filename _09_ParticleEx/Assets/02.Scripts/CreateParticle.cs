using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateParticle : MonoBehaviour
{
    public Object[] arrParticle;

    

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            int sel = Random.Range(0, arrParticle.Length);
            Object part = arrParticle[sel];

            // 파티클 게임오브젝트 생성
            GameObject partObj = 
                (GameObject)Instantiate(part);

            // ParticlePos 주변부에 파티클 생성
            float x = Random.Range(-2f, 2f);
            float y = Random.Range(0f, 3f);
            float z = Random.Range(-2, 2f);

            Vector3 pos = this.transform.position;
            partObj.transform.position = new Vector3(pos.x+ x, pos.y + y, pos.z+ z);
            

            //파티클이 발생하는 시간 이후에 파티클을 소멸시킨다
            ParticleSystem ps = partObj.GetComponent<ParticleSystem>();
            float duration = ps.main.duration;

            Destroy(partObj, duration);

        }    
    }
}
