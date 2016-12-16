using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackTrigger : MonoBehaviour {

    public GameObject Particle;
    new AudioSource audio;
    public AudioClip HitKill;

  

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col)
    
    {
        if(col.isTrigger == true && col.gameObject.tag==("Enemy"))
        {
            
            audio.PlayOneShot(HitKill, 0.5F);
            col.gameObject.SetActive(false);
            Instantiate(Particle, col.transform.position, col.transform.rotation);
       
        }

    }

    

}
