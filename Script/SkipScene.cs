using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipScene : MonoBehaviour
{
    public string sceneName; // �̵��� ���� �̸�

    void Update()
    {
        // E Ű�� ���ȴ��� Ȯ��
        if (Input.GetKeyDown(KeyCode.E))
        {
            // �� ��ȯ
            SceneManager.LoadScene(sceneName);
        }
    }
}


