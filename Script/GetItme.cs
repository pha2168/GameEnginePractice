using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetItme : MonoBehaviour
{
    public GameObject itemCanvas;  // Item ĵ������ �巡�� �� ������� �Ҵ�
    public GameObject Light;
    public RawImage ItmeImage;  // Book �̹����� ������ ����
    private GameObject triggerObject;  // Ʈ���� ������Ʈ�� ������ ����


    // Ʈ���ſ� ������ �� ó��
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            triggerObject = collision.gameObject;  // Ʈ���� ������Ʈ�� �����մϴ�.
        }
    }

    // Ʈ���Ÿ� ������ �� ó��
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            triggerObject = null;  // Ʈ���� ������Ʈ�� null�� �����մϴ�.
        }
    }

    void Update()
    {
        // F Ű�� ������ Ʈ���� ������Ʈ�� ������ �� ó��
        if (Input.GetKeyDown(KeyCode.F) && triggerObject != null)
        {
            ActivateBookImageAndDestroyTrigger();
        }
    }

    // Book �̹����� Ȱ��ȭ�ϰ� Ʈ���� ������Ʈ�� �����ϴ� �޼���
    void ActivateBookImageAndDestroyTrigger()
    {
        ItmeImage.gameObject.SetActive(true);

        Destroy(Light);
    }
}
