using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemLogButton : MonoBehaviour
{
    public GameObject itemImage; // Item �̹����� �巡�� �� ������� �Ҵ�
    public Text arrowLog; // ArrowLog �ؽ�Ʈ�� �巡�� �� ������� �Ҵ�
    public Text bookLog; // BookLog �ؽ�Ʈ�� �巡�� �� ������� �Ҵ�
    public Text keyLog; // KeyLog �ؽ�Ʈ�� �巡�� �� ������� �Ҵ�

    void Start()
    {
        // ���� �� ��� ������Ʈ�� ��Ȱ��ȭ�մϴ�.
        if (itemImage != null) itemImage.SetActive(false);
        if (arrowLog != null) arrowLog.gameObject.SetActive(false);
        if (bookLog != null) bookLog.gameObject.SetActive(false);
        if (keyLog != null) keyLog.gameObject.SetActive(false);
    }

    // ArrowLog ��ư Ŭ�� �� ȣ��� �޼���
    public void OnArrowLogButtonClick()
    {
        StartCoroutine(ActivateAndDeactivate(itemImage, arrowLog));
    }

    // BookLog ��ư Ŭ�� �� ȣ��� �޼���
    public void OnBookLogButtonClick()
    {
        StartCoroutine(ActivateAndDeactivate(itemImage, bookLog));
    }

    // KeyLog ��ư Ŭ�� �� ȣ��� �޼���
    public void OnKeyLogButtonClick()
    {
        StartCoroutine(ActivateAndDeactivate(itemImage, keyLog));
    }

    // �̹����� Ȱ��ȭ�ϰ� 5�� �� ��Ȱ��ȭ�ϴ� �ڷ�ƾ
    IEnumerator ActivateAndDeactivate(GameObject image, Text log)
    {
        if (image != null) image.SetActive(true);
        if (log != null) log.gameObject.SetActive(true);

        yield return new WaitForSeconds(5);

        if (image != null) image.SetActive(false);
        if (log != null) log.gameObject.SetActive(false);
    }
}
