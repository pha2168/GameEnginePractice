using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnd : MonoBehaviour
{
    public GameObject videoCanvas;  // videoCanvas 오브젝트를 연결
    public Camera mainCamera;       // 메인 카메라 오브젝트를 연결
    private GameObject persistantObject; // 씬 간에 유지되는 오브젝트를 저장할 변수

    void Start()
    {
        // 씬 간에 유지되는 오브젝트 찾기
        persistantObject = GameObject.FindWithTag("PersistantObject");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
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

            // 다음 씬에서 씬 간에 유지되는 오브젝트 삭제
            if (persistantObject != null)
            {
                SceneManager.MoveGameObjectToScene(persistantObject, SceneManager.GetActiveScene());
                Destroy(persistantObject);
            }
        }
    }
}