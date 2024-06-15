using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTutorial : MonoBehaviour
{
    public GameObject tutorialCanvas;  // 활성화할 캔버스를 드래그 앤 드롭으로 할당

    void Start()
    {
        if (tutorialCanvas != null)
        {
            tutorialCanvas.SetActive(false);  // 시작 시 캔버스를 비활성화합니다.
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 충돌한 오브젝트가 플레이어인지 확인
        if (collision.CompareTag("Player"))
        {
            tutorialCanvas.SetActive(true);
            gameObject.SetActive(false);

        }
    }

}
