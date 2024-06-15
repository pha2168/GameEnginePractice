using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playButton : MonoBehaviour
{
    public GameObject videoCanvas;  // videoCanvas ������Ʈ�� ����
    public Camera mainCamera;       // ���� ī�޶� ������Ʈ�� ����
    public Button myButton;         // ��ư ������Ʈ�� ����

    void Start()
    {
        // ��ư Ŭ�� �̺�Ʈ�� OnButtonClick �޼��� ����
        myButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
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
    }
}
