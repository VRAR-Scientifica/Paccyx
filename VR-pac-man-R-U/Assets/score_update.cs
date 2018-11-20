using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class score_update : DestroyPellet {

    // Use this for initialization
    public TextMesh tm;
    public static int finalScore;
    // Update is called once per frame
    void Update () {
        GetComponent<TextMesh>().text = score.ToString();
        if (score >= 1000){
            finalScore = score;
            SceneManager.LoadScene("WinScene");
            score = 0;
            
        }
    }
}
