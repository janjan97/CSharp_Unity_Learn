using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontal : MonoBehaviour
{
    public float limitDist = 10f;
    public float speed = 10f;
    int direction = 1;
    
    void Update()
    {
        float x = speed * Time.deltaTime * direction;

        this.transform.Translate(Vector3.right * x);

        if (this.transform.position.x >= limitDist ||
            this.transform.position.x <= -limitDist)
            direction = -direction;
    }
}
