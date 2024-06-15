using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutCanvas3 : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            StartCoroutine(StartFadeOutWithDelay());
        }
    }
    IEnumerator StartFadeOutWithDelay()
    {
        yield return new WaitForSeconds(0.5f);

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
