using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackEnemy : MonoBehaviour{

    private bool attacking = false;
    private float attackTimer = 0;
    private float attackCD = 0.3f;
    public Collider2D  attackTrigger;
    public static bool Alive;
    public AudioClip Hit;
    new AudioSource audio;


    void Awake()
    {
        attackTrigger.enabled = false;
        Alive = true;
        audio = GetComponent<AudioSource>();
    }

    IEnumerator OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Obstacle")
        {
            Alive = false;
            yield return new WaitForSeconds(1);
            Time.timeScale = 0;
        }

    }


    void Update()
    {

        if (Input.GetButtonDown("Fire1") && !attacking)
        {
            audio.PlayOneShot(Hit, 0.5F);
            attacking = true;
            attackTimer = attackCD;

            attackTrigger.enabled = true;

        }

        if (attacking)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                attackTrigger.enabled = false;
            }
        }

    }

}
