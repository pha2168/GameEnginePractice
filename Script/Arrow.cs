using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        // 화살이 플레이어의 전방으로 이동하도록 설정
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed; // forward 대신 up을 사용합니다.

        Destroy(gameObject, 3f);
    }
}
