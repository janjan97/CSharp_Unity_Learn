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

            // ��ƼŬ ���ӿ�����Ʈ ����
            GameObject partObj = 
                (GameObject)Instantiate(part);

            // ParticlePos �ֺ��ο� ��ƼŬ ����
            float x = Random.Range(-2f, 2f);
            float y = Random.Range(0f, 3f);
            float z = Random.Range(-2, 2f);

            Vector3 pos = this.transform.position;
            partObj.transform.position = new Vector3(pos.x+ x, pos.y + y, pos.z+ z);
            

            //��ƼŬ�� �߻��ϴ� �ð� ���Ŀ� ��ƼŬ�� �Ҹ��Ų��
            ParticleSystem ps = partObj.GetComponent<ParticleSystem>();
            float duration = ps.main.duration;

            Destroy(partObj, duration);

        }    
    }
}
