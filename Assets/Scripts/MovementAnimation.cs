using UnityEngine;

public class MovementAnimation : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Animator animator;
    private Movement movement; //reference ke script movement

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        movement = GetComponent<Movement>();
    }
    
    // Update is called once per frame
    void Update()
    {
        //update parameter animator
        animator.SetFloat("speed", rb2d.linearVelocity.magnitude);

        animator.SetFloat("x", movement.GetLastDirection().x);
        animator.SetFloat("y", movement.GetLastDirection().y);

        /*
        //parameter x dan y pada animator
        animator.SetFloat("x", rb2d.linearVelocity.x);
        animator.SetFloat("y", rb2d.linearVelocity.y);
        */
    }
}
