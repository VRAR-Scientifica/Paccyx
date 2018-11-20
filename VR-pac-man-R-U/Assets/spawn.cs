using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawn : MonoBehaviour
{


    public static GameObject pellet1;
    public static GameObject pellet2;
    public static GameObject pellet3;
    public static GameObject pellet4;
    public static GameObject pellet5;
    public static GameObject pellet6;
    public static GameObject pellet7;
    public static GameObject pellet8;

    public GameObject[] a = new GameObject[]{pellet1, pellet2, pellet3, pellet4, pellet5 ,pellet6,pellet7,pellet8};
    
    //float x = Random.Range(-9.0f, 9.0f);
    //float z = Random.Range(-9.0f, 9.0f); 
    // Use this for initialization
    void Start () {
        transform.position = a[(int)(Random.Range(0,8))].transform.position;
        //transform.position = new Vector3(x, 1.04f, z);
    }
	
	// Update is called once per frame
	void Update () {


       
	}
}
