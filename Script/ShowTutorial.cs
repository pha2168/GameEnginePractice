using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTutorial : MonoBehaviour
{
    public GameObject tutorialCanvas;  // Ȱ��ȭ�� ĵ������ �巡�� �� ������� �Ҵ�

    void Start()
    {
        if (tutorialCanvas != null)
        {
            tutorialCanvas.SetActive(false);  // ���� �� ĵ������ ��Ȱ��ȭ�մϴ�.
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // �浹�� ������Ʈ�� �÷��̾����� Ȯ��
        if (collision.CompareTag("Player"))
        {
            tutorialCanvas.SetActive(true);
            gameObject.SetActive(false);

        }
    }

}
