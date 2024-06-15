using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextLog : MonoBehaviour
{
    public Text uiText; // Ÿ���� ȿ���� ������ UI �ؽ�Ʈ
    public string fullText; // ��ü �ؽ�Ʈ ����
    public float delay = 0.1f; // �� ���� ������ ������ �ð�

    private string currentText = "";

    void Start()
    {
        if (uiText != null)
        {
            StartCoroutine(ShowText());
        }
        else
        {
            Debug.LogError("UI Text is not assigned in the inspector.");
        }
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            uiText.text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }
}
