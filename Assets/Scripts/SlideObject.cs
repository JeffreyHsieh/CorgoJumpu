using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideObject : MonoBehaviour {
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
