using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public GameObject arrowPrefab;
    public Transform arrowSpawnPoint;
    public LayerMask groundLayer;
    public Transform groundCheck; // 플레이어 발밑에 위치한 작은 빈 게임 오브젝트

    private Animator animator;
    private Rigidbody2D rb;
    private bool isFacingRight = true;
    private bool isGrounded = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        HandleMovement();
        HandleAttack();
        HandleJump();
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

    void HandleAttack()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            // 공격 애니메이션 재생
            animator.SetTrigger("Attack");

            // 일정 시간 후에 화살 소환
            Invoke("SpawnArrow", 0.5f);
        }
    }

    void HandleJump()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // 점프 애니메이션 재생
            animator.SetTrigger("Jump");

            // 점프
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    void SpawnArrow()
    {
        // 화살 소환
        GameObject arrow = Instantiate(arrowPrefab, arrowSpawnPoint.position, Quaternion.identity);

        // 화살의 방향을 플레이어의 방향에 맞게 설정
        if (!isFacingRight)
        {
            // 왼쪽을 볼 때
            arrow.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else
        {
            // 오른쪽을 볼 때
            arrow.transform.rotation = Quaternion.Euler(0, 0, -90);
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
