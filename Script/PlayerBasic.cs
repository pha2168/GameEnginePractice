using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBasic : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Animator animator;
    private bool isFacingRight = true;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        float move = Input.GetAxis("Horizontal");

        if (move != 0)
        {
            // 이동
            transform.Translate(Vector3.right * move * moveSpeed * Time.deltaTime);

            // 플레이어 회전
            if (move > 0 && !isFacingRight)
            {
                Flip();
            }
            else if (move < 0 && isFacingRight)
            {
                Flip();
            }

            // 걷기 애니메이션 재생
            animator.SetBool("Walk", true);
        }
        else
        {
            // 걷기 애니메이션 중지
            animator.SetBool("Walk", false);
        }
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
