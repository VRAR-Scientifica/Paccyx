using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_end : MonoBehaviour {
    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public float toggleAngle2 = 240.0f;
    // Use this for initialization

    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (vrCamera.eulerAngles.x >= toggleAngle2 && vrCamera.eulerAngles.x < 330.0f)
        {
            SceneManager.LoadScene("Instructions");
        }

    }
}
