using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnd : MonoBehaviour
{
    public GameObject videoCanvas;  // videoCanvas ������Ʈ�� ����
    public Camera mainCamera;       // ���� ī�޶� ������Ʈ�� ����
    private GameObject persistantObject; // �� ���� �����Ǵ� ������Ʈ�� ������ ����

    void Start()
    {
        // �� ���� �����Ǵ� ������Ʈ ã��
        persistantObject = GameObject.FindWithTag("PersistantObject");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // videoCanvas ������Ʈ Ȱ��ȭ
            if (videoCanvas != null)
            {
                videoCanvas.SetActive(true);
            }

            // ���� ī�޶� ����� �ҽ� ��Ȱ��ȭ
            if (mainCamera != null)
            {
                AudioSource audioSource = mainCamera.GetComponent<AudioSource>();
                if (audioSource != null)
                {
                    audioSource.enabled = false;
                }
            }

            // ���� ������ �� ���� �����Ǵ� ������Ʈ ����
            if (persistantObject != null)
            {
                SceneManager.MoveGameObjectToScene(persistantObject, SceneManager.GetActiveScene());
                Destroy(persistantObject);
            }
        }
    }
}