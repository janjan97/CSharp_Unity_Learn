using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
       
    public float intervalReading = 1f;
    public int countReading = 0;
   
    public float intervalMusicTime = 1f;
    int countMusic = 0;

    // Update�ʹ� ������ �ݺ��ϴ� ���� �ΰ��� �����
    // �������ڸ��� ���� ���������� ����Ǵ� ���� ��ƾ�� 2�� �����Ѵ�.
    // �̶� ���� ��ƾ�� Coroutine�� ����Ѵ�
    void Start()
    {
        // ���ķ� �����ϴ� 2���� ��ƾ�� �����ߴ�.
        // ����Ƽ�� �ڷ�ƾ�� �Ϲ����� �������� ������ �Ѵ�.
        // �� ����ȭ�� ���� �ʾƵ� �ȴ�.
        // ���ÿ� �����ϴ� ���� �ƴϱ� ������
        // ����Ƽ ������ Single Thread�� ������ �ڷ�ƾ�� ������� �ִ� ���̴�.
        StartCoroutine(coReading());
        StartCoroutine(coMusic());
        // ���Ʒ� �ΰ��� ����
        //StartCoroutine("coReading");
        //StartCoroutine("coMusic");
    }

    IEnumerator coReading()
    {
        while (true)
        {
            yield return new WaitForSeconds(intervalReading);
            Debug.Log($"å�� �д´� {countReading++}");
        }
        
    }

    IEnumerator coMusic()
    {
        while (true)
        {
            yield return new WaitForSeconds(intervalMusicTime);
            Debug.Log($"������ ��´� {countMusic++}");
        }
        
    }

}
