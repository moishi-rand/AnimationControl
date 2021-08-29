using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 30f;
    [SerializeField] private float moveSpeed = 150f;
    
    private Animator animator;
    private CharacterController controller;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        animator.SetFloat("Speed", vertical);
        transform.Rotate(Vector3.up,horizontal * rotationSpeed * Time.deltaTime);
        controller.SimpleMove(transform.forward * moveSpeed * vertical * Time.deltaTime);
    }
}
