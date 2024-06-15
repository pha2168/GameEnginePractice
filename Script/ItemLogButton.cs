using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemLogButton : MonoBehaviour
{
    public GameObject itemImage;
    public Text arrowLog;
    public Text bookLog;
    public Text keyLog;

    void Start()
    {
        if (itemImage != null) itemImage.SetActive(false);
        if (arrowLog != null) arrowLog.gameObject.SetActive(false);
        if (bookLog != null) bookLog.gameObject.SetActive(false);
        if (keyLog != null) keyLog.gameObject.SetActive(false);
    }

    public void OnArrowLogButtonClick()
    {
        StartCoroutine(ActivateAndDeactivate(itemImage, arrowLog));
    }

    public void OnBookLogButtonClick()
    {
        StartCoroutine(ActivateAndDeactivate(itemImage, bookLog));
    }

    public void OnKeyLogButtonClick()
    {
        StartCoroutine(ActivateAndDeactivate(itemImage, keyLog));
    }

    IEnumerator ActivateAndDeactivate(GameObject image, Text log)
    {
        if (image != null) image.SetActive(true);
        if (log != null) log.gameObject.SetActive(true);

        yield return new WaitForSeconds(5);

        if (image != null) image.SetActive(false);
        if (log != null) log.gameObject.SetActive(false);
    }
}
