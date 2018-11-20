using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPellet:controller {

    public AudioClip ps;

    public AudioSource src;

    private void Start()
    {
        src.clip = ps;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
       
            Destroy(gameObject);
            score += 10;
        }
        if (col.gameObject.tag == "Player")
        {
            src.Play();
        }
    }

  

}
