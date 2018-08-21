using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keep : MonoBehaviour {

    void Start () {
        DontDestroyOnLoad(gameObject);
    }
}
