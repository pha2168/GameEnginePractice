using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutCanvas2 : MonoBehaviour
{
    public CanvasGroup canvasGroup; // UI ����� CanvasGroup�� ����

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(StartFadeOutWithDelay());
        }
    }
    IEnumerator StartFadeOutWithDelay()
    {
        yield return new WaitForSeconds(0.5f);

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
