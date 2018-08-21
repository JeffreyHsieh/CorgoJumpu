using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
    private GameManager gameManager;
    void OnCollisionEnter2D(Collision2D collider)
    {
        gameManager.gameOver();
    }

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
}
