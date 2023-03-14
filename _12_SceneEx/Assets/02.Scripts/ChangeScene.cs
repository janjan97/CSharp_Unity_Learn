using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Player �±׸� ���� ������Ʈ�� �ƴϸ� �ٷ� ��ȯ
        if (!other.CompareTag("Player"))
            return;

        // ���� Ȱ��ȭ�� ���̸��� ��´�.
        Scene nowScene = SceneManager.GetActiveScene();
        
        switch (nowScene.name)
        {
            case "FirstScene":
                SceneManager.LoadScene("SecondScene");
                break;
            case "SecondScene":
                SceneManager.LoadScene("FirstScene");
                break;

        }
    }
}
