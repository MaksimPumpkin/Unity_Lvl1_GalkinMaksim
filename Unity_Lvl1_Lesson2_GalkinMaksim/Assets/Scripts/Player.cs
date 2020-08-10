using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed;
    float jump;
    bool right;
    Rigidbody2D RB;
    Vector3 direction;
    float horizontal;
    float vertical;
    SpriteRenderer Look;

    void Start()
    {
        Look = GetComponent<SpriteRenderer>();
        speed = 5;
        jump = 10;
        RB = GetComponent<Rigidbody2D>();
    }

    private void Move()
    {
        direction = Vector3.right * horizontal;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
    }

    private void Jump()
    {
        direction = Vector3.up;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, jump * Time.deltaTime);
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (Input.GetButton("Horizontal"))
        {
            if (horizontal > 0)
            {
                Look.flipX = false;;
            }
            else {
                Look.flipX = true;;
            }
            Move();
        }

        if (Input.GetButton("Vertical"))
        {
            Jump();
        }
    }
}
