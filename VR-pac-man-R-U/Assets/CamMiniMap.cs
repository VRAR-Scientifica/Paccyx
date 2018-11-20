using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMiniMap : MonoBehaviour {

    // Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(0, 40, 1.5f);
        transform.rotation = Quaternion.Euler(90, 0, 0);

    }
}
