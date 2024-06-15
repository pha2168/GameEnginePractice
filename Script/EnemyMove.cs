using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float leftBoundary = -5f; // 왼쪽 경계
    public float rightBoundary = 5f; // 오른쪽 경계

    public bool movingRight = false; // 왼쪽을 보고 시작
    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        if (movingRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

            if (transform.position.x >= rightBoundary)
            {
                movingRight = false;
                Flip();
            }
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

            if (transform.position.x <= leftBoundary)
            {
                movingRight = true;
                Flip();
            }
        }
    }

    void Flip()
    {
        // 스프라이트의 방향을 반전시킵니다.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector3(leftBoundary, transform.position.y, transform.position.z),
                        new Vector3(rightBoundary, transform.position.y, transform.position.z));
    }
}
