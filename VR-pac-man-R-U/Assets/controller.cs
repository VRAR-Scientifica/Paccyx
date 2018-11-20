using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public float speed = 3.0f;
    public bool moveForward;
    public static int score;


    private CharacterController cc;

	void Start () {
        cc = GetComponent<CharacterController>();
    }
   


    void Update () {


       
            if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90)
            {
                moveForward = false;
            }
            else
            {
                moveForward = true;
            }

            if (moveForward)
            {
                Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

                cc.SimpleMove(forward * speed);
            }
        



    }
}
