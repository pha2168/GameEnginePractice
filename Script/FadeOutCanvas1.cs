using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutCanvas1 : MonoBehaviour
{
    private bool A = false;
    private bool D = false;
    public CanvasGroup canvasGroup; // UI 요소의 CanvasGroup을 참조

    void Update()
    {
        // 'a' 키를 누르면 A가 true가 됩니다.
        if (Input.GetKeyDown(KeyCode.A))
        {
            A = true;
        }

        // 'd' 키를 누르면 D가 true가 됩니다.
        if (Input.GetKeyDown(KeyCode.D))
        {
            D = true;
        }

        // 두 값이 모두 true이면 페이드 아웃 코루틴을 시작합니다.
        if (A && D)
        {
            StartCoroutine(StartFadeOutWithDelay());
        }
    }

    IEnumerator StartFadeOutWithDelay()
    {
        // 두 키가 눌렸으므로 더 이상 코루틴을 중복 실행하지 않도록 함.
        A = false;
        D = false;

        // 3초 대기
        yield return new WaitForSeconds(1f);

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
