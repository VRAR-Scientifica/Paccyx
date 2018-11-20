using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public GameObject tl;
    public GameObject tr;

    public Vector3 tlpos;
    public Vector3 trpos;
    // Use this for initialization
    void Start () {
        tlpos = tl.transform.position;
        trpos = tr.transform.position;
    }

    // Update is called once per frame
    void Update () {
		
        if(transform.position.x > 10f)
        {
            transform.position = trpos;
        }
        if (transform.position.x < -10f)
        {
            transform.position = tlpos;
        }

    }
}
