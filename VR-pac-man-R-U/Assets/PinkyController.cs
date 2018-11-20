using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkyController : MonoBehaviour {

     public Transform target;
    public Transform myTransform;

    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        transform.LookAt(target);
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 3 * Time.deltaTime);
    }
}
