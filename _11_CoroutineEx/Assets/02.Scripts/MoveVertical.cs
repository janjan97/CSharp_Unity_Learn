using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVertical : MonoBehaviour
{
    public float limitDist = 4f;
    public float speed = 4f;
    int direction = 1;

    void Update()
    {
        float y = speed * Time.deltaTime * direction;

        this.transform.Translate(Vector3.up * y);

        if (this.transform.position.y >= limitDist ||
            this.transform.position.y <= -limitDist)
            direction = -direction;
    }
}
