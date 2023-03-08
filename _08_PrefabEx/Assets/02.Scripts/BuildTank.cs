using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTank : MonoBehaviour
{
    public int numOfBuild = 10;
    public Object tankPrefab;
    void Start()
    {
        for (int i = 0; i < numOfBuild; i++)
        {
            GameObject tankObj = (GameObject)Instantiate(tankPrefab);
            float x = Random.Range(-5f, 5f);
            float y = 0.3875f;
            float z = Random.Range(-5f, 5f);
            tankObj.GetComponent<Transform>().position = new Vector3(x, y, z);
        }
    }
}
