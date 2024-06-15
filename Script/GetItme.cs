using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetItme : MonoBehaviour
{
    public GameObject itemCanvas;
    public GameObject Light;
    public RawImage ItmeImage;
    private GameObject triggerObject;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            triggerObject = collision.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            triggerObject = null;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && triggerObject != null)
        {
            ActivateBookImageAndDestroyTrigger();
        }
    }

    void ActivateBookImageAndDestroyTrigger()
    {
        ItmeImage.gameObject.SetActive(true);

        Destroy(Light);
    }
}
