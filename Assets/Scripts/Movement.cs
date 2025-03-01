using System;
using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] 
//^^^ini klo malas nambahin rigidbody, jd setiap kita masukkan script movement ke objek maka objek tsb otomatis mendapat rigidbody2d

public class Movements : MonoBehaviour
{

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
}
