using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
       
    public float intervalReading = 1f;
    public int countReading = 0;
   
    public float intervalMusicTime = 1f;
    int countMusic = 0;

    // Update와는 별개로 반복하는 루프 두개를 만든다
    // 시작하자마자 각각 독립적으로 진행되는 병렬 루틴을 2개 생성한다.
    // 이때 병렬 루틴은 Coroutine을 사용한다
    void Start()
    {
        // 병렬로 진행하는 2개의 루틴을 진행했다.
        // 유니티의 코루틴은 일반적인 스레드의 역할을 한다.
        // 단 동기화는 하지 않아도 된다.
        // 동시에 접근하는 것은 아니기 때문에
        // 유니티 내부의 Single Thread가 각각의 코루틴을 진행시켜 주는 것이다.
        StartCoroutine(coReading());
        StartCoroutine(coMusic());
        // 위아래 두개는 같다
        //StartCoroutine("coReading");
        //StartCoroutine("coMusic");
    }

    IEnumerator coReading()
    {
        while (true)
        {
            yield return new WaitForSeconds(intervalReading);
            Debug.Log($"책을 읽는다 {countReading++}");
        }
        
    }

    IEnumerator coMusic()
    {
        while (true)
        {
            yield return new WaitForSeconds(intervalMusicTime);
            Debug.Log($"음악을 듣는다 {countMusic++}");
        }
        
    }

}
