using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutCanvas1 : MonoBehaviour
{
    private bool A = false;
    private bool D = false;
    public CanvasGroup canvasGroup;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            A = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            D = true;
        }
        if (A && D)
        {
            StartCoroutine(StartFadeOutWithDelay());
        }
    }

    IEnumerator StartFadeOutWithDelay()
    {
        A = false;
        D = false;

        yield return new WaitForSeconds(1f);

        StartCoroutine(FadeOutAndDisable());
    }

    IEnumerator FadeOutAndDisable()
    {
        float duration = 0.5f;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            canvasGroup.alpha = 1 - Mathf.Clamp01(elapsedTime / duration);
            yield return null;
        }

        gameObject.SetActive(false);
    }
}
