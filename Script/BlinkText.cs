using UnityEngine;
using UnityEngine.UI;

public class BlinkText : MonoBehaviour
{
    public Text uiText; // UI �ؽ�Ʈ ������Ʈ�� ����
    public float fadeDuration = 1f; // ���̵� ��/�ƿ� �ð�

    private float timer = 0f;
    private bool isFadingIn = true;

    void Update()
    {
        if (isFadingIn)
        {
            // ���̵� ��: ���� ���� ������Ŵ
            timer += Time.deltaTime / fadeDuration;
            if (timer >= 1f)
            {
                timer = 1f;
                isFadingIn = false;
            }
        }
        else
        {
            // ���̵� �ƿ�: ���� ���� ���ҽ�Ŵ
            timer -= Time.deltaTime / fadeDuration;
            if (timer <= 0f)
            {
                timer = 0f;
                isFadingIn = true;
            }
        }

        // ���� �� ����
        Color color = uiText.color;
        color.a = timer;
        uiText.color = color;
    }
}
