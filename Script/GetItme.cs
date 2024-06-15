using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetItme : MonoBehaviour
{
    public GameObject itemCanvas;  // Item 캔버스를 드래그 앤 드롭으로 할당
    public GameObject Light;
    public RawImage ItmeImage;  // Book 이미지를 참조할 변수
    private GameObject triggerObject;  // 트리거 오브젝트를 참조할 변수


    // 트리거에 들어왔을 때 처리
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            triggerObject = collision.gameObject;  // 트리거 오브젝트를 저장합니다.
        }
    }

    // 트리거를 나갔을 때 처리
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            triggerObject = null;  // 트리거 오브젝트를 null로 설정합니다.
        }
    }

    void Update()
    {
        // F 키가 눌리고 트리거 오브젝트가 존재할 때 처리
        if (Input.GetKeyDown(KeyCode.F) && triggerObject != null)
        {
            ActivateBookImageAndDestroyTrigger();
        }
    }

    // Book 이미지를 활성화하고 트리거 오브젝트를 삭제하는 메서드
    void ActivateBookImageAndDestroyTrigger()
    {
        ItmeImage.gameObject.SetActive(true);

        Destroy(Light);
    }
}
