using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logo : MonoBehaviour {

    // Update is called once per frame
    void Update () {
        StartCoroutine("timeCheck");
        
    }

    IEnumerator timeCheck(){
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("SampleScene");
    }

}
