using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    public Transform firePos;
    public Object ball;
    public float minScale = 0.3f;
    public float maxScale = 1.5f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            float y = Random.Range(-20f, 20f); // y축
            float x = Random.Range(-10f, 10f); // x축 
            Quaternion fireRot = firePos.rotation;
            Quaternion rot = 
                Quaternion.Euler(fireRot.x+x, fireRot.y+y, fireRot.z);
            GameObject ballObj =
                //(GameObject)Instantiate(ball, firePos.position, firePos.rotation);
                (GameObject)Instantiate(ball, firePos.position, rot);

            // 생성한 오브젝트의 크기를 조정해준다.
            float xscale = ballObj.transform.localScale.x;
            float yscale = ballObj.transform.localScale.y;
            float zscale = ballObj.transform.localScale.z;
            float _xscale = Random.Range(xscale * 0.3f, xscale * 1.5f);
            float _yscale = Random.Range(yscale * 0.3f, yscale * 1.5f);
            float _zscale = Random.Range(zscale * 0.3f, zscale * 1.5f);
            ballObj.transform.localScale = new Vector3(_xscale, _yscale, _zscale);

            //2초후 제거
            //Destroy(ballObj, 2f);
        }
    }
}
