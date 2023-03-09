using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Shot : MonoBehaviour
{
    public Transform firePos;
    public Object ball;  

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            Quaternion fireRot = firePos.rotation;
            Quaternion rot =
                Quaternion.Euler(fireRot.x, fireRot.y, fireRot.z);
            GameObject ballObj =
                //(GameObject)Instantiate(ball, firePos.position, firePos.rotation);
                (GameObject)Instantiate(ball, firePos.position, rot);

            //2초후 제거
            //Destroy(ballObj, 2f);
        }
    }

}
