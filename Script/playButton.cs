using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playButton : MonoBehaviour
{
    public GameObject videoCanvas;  // videoCanvas 오브젝트를 연결
    public Camera mainCamera;       // 메인 카메라 오브젝트를 연결
    public Button myButton;         // 버튼 오브젝트를 연결

    void Start()
    {
        // 버튼 클릭 이벤트에 OnButtonClick 메서드 연결
        myButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        // videoCanvas 오브젝트 활성화
        if (videoCanvas != null)
        {
            videoCanvas.SetActive(true);
        }

        // 메인 카메라 오디오 소스 비활성화
        if (mainCamera != null)
        {
            AudioSource audioSource = mainCamera.GetComponent<AudioSource>();
            if (audioSource != null)
            {
                audioSource.enabled = false;
            }
        }
    }
}
