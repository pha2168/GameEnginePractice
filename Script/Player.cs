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
    public Transform groundCheck;

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
            transform.Translate(Vector3.right * move * moveSpeed * Time.deltaTime);

            if (move > 0 && !isFacingRight)
            {
                Flip();
            }
            else if (move < 0 && isFacingRight)
            {
                Flip();
            }

            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    }

    void HandleAttack()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetTrigger("Attack");

            Invoke("SpawnArrow", 0.5f);
        }
    }

    void HandleJump()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            animator.SetTrigger("Jump");

            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    void SpawnArrow()
    {
        GameObject arrow = Instantiate(arrowPrefab, arrowSpawnPoint.position, Quaternion.identity);

        if (!isFacingRight)
        {
            arrow.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else
        {
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
