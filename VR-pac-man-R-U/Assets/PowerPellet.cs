using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPellet : MonoBehaviour {

    public Material[] mat;

    public GameObject inky;
    //public GameObject blinky;
    //public GameObject pinky;
    //public GameObject clyde;

    Renderer rendInky;

    void Start()
    {
        rendInky.GetComponentInChildren<Renderer>().material = mat[0];

    }

    private void OnTriggerEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            rendInky.material = mat[1];
        }
    }

}
