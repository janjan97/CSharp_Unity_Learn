using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineMove : MonoBehaviour
{
    public Transform redCube;
    public float limitXDist = 10f;
    public float speedX = 10f;
    int directionX = 1;

    public Transform blueCube;
    public float limitYDist = 4f;
    public float speedY = 2f;
    int directionY = 1;
    void Start()
    {
        StartCoroutine(coMoveX());
        StartCoroutine(coMoveY());
    }
    
    IEnumerator coMoveX()
    {
        while (true)
        {
            //yield return new WaitForEndOfFrame();
            yield return null;
            float x = speedX * directionX * Time.deltaTime;
            redCube.Translate(Vector3.right * x);
            if(redCube.position.x >= limitXDist ||
                redCube.position.x <= -limitXDist)
            {
                directionX = -directionX;
            }
        }        
    }
    
    IEnumerator coMoveY()
    {
        while (true)
        {
            //yield return null;
            yield return new WaitForEndOfFrame();
            float y = speedY * directionY * Time.deltaTime;
            blueCube.Translate(Vector3.up * y);
            if (blueCube.position.y >= limitYDist ||
                blueCube.position.y <= -limitYDist)
            {
                directionY = -directionY;
            }
        }        
    }
}
