using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigid;
    private Animator anim;
    public float jumpPower;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        // Rigidbody 설정 확인
        rigid.freezeRotation = true; // 회전 방지
    }

    void Update()
    {
        // 점프
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * jumpPower, ForceMode2D.Impulse);
            anim.SetBool("isJumping", true);
        }


        // 이동 처리
        float x = Input.GetAxisRaw("Horizontal");

        // Rigidbody의 velocity로 이동 처리
        Vector3 velocity = rigid.velocity;
        velocity.x = x * moveSpeed; // x축 속도 변경
        rigid.velocity = velocity;


        //이미지 방향 전환
        if (Input.GetButtonDown("Horizontal"))
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == 1;


        //walk Animation
        if (x == 0)
            anim.SetBool("isWalking", false);
        else
            anim.SetBool("isWalking", true);
    }

    void FixedUpdate()
    {
        //Landing Platform
        if (rigid.velocity.y < 0)
        {
            Debug.DrawRay(rigid.position, Vector3.down, new Color(0, 1, 0));
            RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("Platform"));
            if (rayHit.collider != null)
            {
                if (rayHit.distance < 0.7f)
                    anim.SetBool("isJumping", false);
            }
        }
    }
}
