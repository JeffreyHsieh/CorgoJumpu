using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoint : MonoBehaviour {
    private GameManager gameManager;
    public int point;
    void OnTriggerEnter2D(Collider2D collider)
    {
        gameManager.addPoint(point);
    }

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
}
