using System;
using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))] 
//^^^ini klo malas nambahin rigidbody, jd setiap kita masukkan script movement ke objek maka objek tsb otomatis mendapat rigidbody2d

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void SetDirection(Vector2 direction)
    {
        rb2d.linearVelocity = direction * speed;
    }

//untuk input system kita pakai yg dibawah ini:
    public void SetDirection(CallbackContext ctx) //#using static UnityEngine.InputSystem.InputAction;
    {
        if (ctx.phase == InputActionPhase.Performed || ctx.phase == InputActionPhase.Canceled)
        {
            Vector2 direction = ctx.ReadValue<Vector2>();
            //print($"Set Direction {direction}");
            SetDirection(direction);
        }
        
    }

/*
    [SerializeField, Range(5f, 20f)] private float speed;
    private Rigidbody2D rb2d;
    private float direction;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if(rb2d is null)
        {
            gameObject.AddComponent<Rigidbody2D>();
        }
    }
    private void Update()
    {
        UpdatePosition();

        //ini untuk testing aja lalu dihapus klo udh selesai test:
        //SetDirection(Input.GetAxisRaw("Horizontal"));
        //atau klo SetDirection (int direction) bisa gini:
        //SetDirection((int)Input.GetAxisRaw("Horizontal"));
    }

    private void UpdatePosition()
    {
        UnityEngine.Vector2 velocity = rb2d.linearVelocity; 
        velocity.x = direction * speed;
        rb2d.linearVelocity = velocity;
    }

    public void SetDirection(float direction)
    {
        this.direction = direction;
    }
    */
}
