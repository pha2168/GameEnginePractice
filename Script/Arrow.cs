using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        // ȭ���� �÷��̾��� �������� �̵��ϵ��� ����
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed; // forward ��� up�� ����մϴ�.

        // 10�� �Ŀ� ȭ���� ����
        Destroy(gameObject, 3f);
    }
}
