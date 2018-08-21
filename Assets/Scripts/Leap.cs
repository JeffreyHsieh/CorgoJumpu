using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leap : MonoBehaviour {

    private float backgroundWidth = 10.24f;
	void Start () {
	}
	
	void Update () {
        if(transform.position.x < -backgroundWidth)
        {
            leapBackground();
        }
	}

    private void leapBackground()
    {
        transform.position += new Vector3(backgroundWidth * 2.0f, 0.0f, 0.0f);
    }
}
