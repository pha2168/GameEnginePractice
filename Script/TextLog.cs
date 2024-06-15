using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextLog : MonoBehaviour
{
    public Text uiText; // 타이핑 효과를 적용할 UI 텍스트
    public string fullText; // 전체 텍스트 내용
    public float delay = 0.1f; // 각 글자 사이의 딜레이 시간

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
