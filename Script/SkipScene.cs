using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipScene : MonoBehaviour
{
    public string sceneName; // 이동할 씬의 이름

    void Update()
    {
        // E 키가 눌렸는지 확인
        if (Input.GetKeyDown(KeyCode.E))
        {
            // 씬 전환
            SceneManager.LoadScene(sceneName);
        }
    }
}


