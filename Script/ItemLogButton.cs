using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemLogButton : MonoBehaviour
{
    public GameObject itemImage; // Item 이미지를 드래그 앤 드롭으로 할당
    public Text arrowLog; // ArrowLog 텍스트를 드래그 앤 드롭으로 할당
    public Text bookLog; // BookLog 텍스트를 드래그 앤 드롭으로 할당
    public Text keyLog; // KeyLog 텍스트를 드래그 앤 드롭으로 할당

    void Start()
    {
        // 시작 시 모든 오브젝트를 비활성화합니다.
        if (itemImage != null) itemImage.SetActive(false);
        if (arrowLog != null) arrowLog.gameObject.SetActive(false);
        if (bookLog != null) bookLog.gameObject.SetActive(false);
        if (keyLog != null) keyLog.gameObject.SetActive(false);
    }

    // ArrowLog 버튼 클릭 시 호출될 메서드
    public void OnArrowLogButtonClick()
    {
        StartCoroutine(ActivateAndDeactivate(itemImage, arrowLog));
    }

    // BookLog 버튼 클릭 시 호출될 메서드
    public void OnBookLogButtonClick()
    {
        StartCoroutine(ActivateAndDeactivate(itemImage, bookLog));
    }

    // KeyLog 버튼 클릭 시 호출될 메서드
    public void OnKeyLogButtonClick()
    {
        StartCoroutine(ActivateAndDeactivate(itemImage, keyLog));
    }

    // 이미지를 활성화하고 5초 후 비활성화하는 코루틴
    IEnumerator ActivateAndDeactivate(GameObject image, Text log)
    {
        if (image != null) image.SetActive(true);
        if (log != null) log.gameObject.SetActive(true);

        yield return new WaitForSeconds(5);

        if (image != null) image.SetActive(false);
        if (log != null) log.gameObject.SetActive(false);
    }
}
