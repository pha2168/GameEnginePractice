using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutCanvas2 : MonoBehaviour
{
    public CanvasGroup canvasGroup; // UI 요소의 CanvasGroup을 참조

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

        // 페이드 아웃 코루틴 시작
        StartCoroutine(FadeOutAndDisable());
    }

    IEnumerator FadeOutAndDisable()
    {
        float duration = 0.5f; // 페이드 아웃 지속 시간
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            canvasGroup.alpha = 1 - Mathf.Clamp01(elapsedTime / duration);
            yield return null;
        }

        // 페이드 아웃이 완료되면 오브젝트를 비활성화합니다.
        gameObject.SetActive(false);
    }

}
