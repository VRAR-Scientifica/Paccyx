using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Somerandomsciptplswork : MonoBehaviour {

    public Canvas m_canvas;

    void Start()
    {
        ChangeRenderMode(RenderMode.WorldSpace);
    }

    private void ChangeRenderMode(RenderMode m)
    {
        m_canvas.renderMode = m;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
