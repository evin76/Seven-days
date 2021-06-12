using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using  UnityEngine.UI;

public class Player_Movement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Animator animator;
    private Collider2D collider;
    Vector2 movement;
    private Dialogue manager;

    [SerializeField] private LayerMask water;
    [SerializeField] private int health;
    [SerializeField] private Text healthAmount;

    public GameObject aftermath;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        collider = GetComponent<Collider2D>();
        healthAmount.text = health.ToString();
        manager = FindObjectOfType<Dialogue>();
    }

    void Update()
    {
        Move();
        if (collider.IsTouchingLayers(water))
        {
            manager.leftClick.SetActive(true);
            if (manager.rightClick.activeSelf)
            {
                manager.leftClick.SetActive(false);
            }
            if (manager.flag)
            {
                if (manager.drankSaltyWater == 2)
                {
                    health --;
                    Health();
                }
            }
            manager.flag = false;
        }
        else
        {
            manager.leftClick.SetActive(false);
        }
    }
    private void Health()
    {
        //health--;
        healthAmount.text = health.ToString();
        //if (health <= 0)
        //{
            aftermath.SetActive(true);
        //}
    }

    
    private void Move()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    
}
