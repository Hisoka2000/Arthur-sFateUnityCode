using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFinal : MonoBehaviour
{
    public bool jump = false;
    public float jumpForce = 10.0f;
    private bool grounded = false;
    public double movementSpeed = 10;
    public Animator anim;


    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D hit)
    {
        grounded = true;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy" || col.gameObject.tag == "Obstacle")
        {
            anim.SetTrigger("Death");
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5 * Time.deltaTime / Time.fixedDeltaTime), ForceMode2D.Impulse);
        }
    }

    void Update()
    {
        movementSpeed = movementSpeed + 0.002;

        if (Input.GetButtonDown("Jump"))
        {
            if (grounded == true)
            {
                jump = true;
                grounded = false;
                anim.SetTrigger("Jump");
            }
        }

        if (Input.GetButtonDown("Fire1"))
        {

            anim.SetTrigger("Attack");

        }

    }

    void FixedUpdate()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2((float)movementSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if (jump == true)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce * Time.deltaTime / Time.fixedDeltaTime), ForceMode2D.Impulse);

            jump = false;
        }

        if (AttackEnemy.Alive == false)
        {
            GetComponent<Rigidbody2D>().velocity = (new Vector2(((float)(-0.5*movementSpeed)), GetComponent<Rigidbody2D>().velocity.y));
            

        }


    }


}
