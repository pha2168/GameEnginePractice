using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutCanvas1 : MonoBehaviour
{
    private bool A = false;
    private bool D = false;
    public CanvasGroup canvasGroup; // UI ����� CanvasGroup�� ����

    void Update()
    {
        // 'a' Ű�� ������ A�� true�� �˴ϴ�.
        if (Input.GetKeyDown(KeyCode.A))
        {
            A = true;
        }

        // 'd' Ű�� ������ D�� true�� �˴ϴ�.
        if (Input.GetKeyDown(KeyCode.D))
        {
            D = true;
        }

        // �� ���� ��� true�̸� ���̵� �ƿ� �ڷ�ƾ�� �����մϴ�.
        if (A && D)
        {
            StartCoroutine(StartFadeOutWithDelay());
        }
    }

    IEnumerator StartFadeOutWithDelay()
    {
        // �� Ű�� �������Ƿ� �� �̻� �ڷ�ƾ�� �ߺ� �������� �ʵ��� ��.
        A = false;
        D = false;

        // 3�� ���
        yield return new WaitForSeconds(1f);

        // ���̵� �ƿ� �ڷ�ƾ ����
        StartCoroutine(FadeOutAndDisable());
    }

    IEnumerator FadeOutAndDisable()
    {
        float duration = 0.5f; // ���̵� �ƿ� ���� �ð�
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            canvasGroup.alpha = 1 - Mathf.Clamp01(elapsedTime / duration);
            yield return null;
        }

        // ���̵� �ƿ��� �Ϸ�Ǹ� ������Ʈ�� ��Ȱ��ȭ�մϴ�.
        gameObject.SetActive(false);
    }
}
