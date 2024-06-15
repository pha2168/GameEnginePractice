using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public void Quit()
    {
        // 게임 종료
        Application.Quit();

        // 만약 에디터에서 실행 중이면 게임 종료가 동작하지 않을 수 있습니다.
        // 에디터에서 테스트할 때는 아래 주석을 해제하고 사용하세요.
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
