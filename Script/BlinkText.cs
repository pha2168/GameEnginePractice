using UnityEngine;
using UnityEngine.UI;

public class BlinkText : MonoBehaviour
{
    public Text uiText; // UI 텍스트 컴포넌트를 연결
    public float fadeDuration = 1f; // 페이드 인/아웃 시간

    private float timer = 0f;
    private bool isFadingIn = true;

    void Update()
    {
        if (isFadingIn)
        {
            // 페이드 인: 알파 값을 증가시킴
            timer += Time.deltaTime / fadeDuration;
            if (timer >= 1f)
            {
                timer = 1f;
                isFadingIn = false;
            }
        }
        else
        {
            // 페이드 아웃: 알파 값을 감소시킴
            timer -= Time.deltaTime / fadeDuration;
            if (timer <= 0f)
            {
                timer = 0f;
                isFadingIn = true;
            }
        }

        // 알파 값 설정
        Color color = uiText.color;
        color.a = timer;
        uiText.color = color;
    }
}
