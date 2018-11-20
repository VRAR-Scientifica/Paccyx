using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finalscore : Death {

    // Use this for initialization
    public TextMesh text;
	
	// Update is called once per frame
	void Update () {
        
        GetComponent<TextMesh>().text = "Your Score:" + finalScore.ToString();
        
    }
}
