using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowCamera : MonoBehaviour
{
    public Transform playerTransform;
    public float minX = -3.5f;
    public float maxX = 14f;

    void Update()
    {
        // 플레이어가 있는 위치로 카메라를 이동
        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Clamp(playerTransform.position.x, minX, maxX);
        transform.position = newPosition;
    }
}
