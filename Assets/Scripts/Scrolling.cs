using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {
    private GameManager gameManager;
    private Rigidbody2D rigidbody;
    private float scrollSpeed = -4.0f;

	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(scrollSpeed, 0);
	}
	
	void Update ()
    {
        rigidbody.velocity = new Vector2(scrollSpeed - (gameManager.score / 100), 0);
        if (gameManager.end == true)
        {
            rigidbody.velocity = Vector2.zero;
        }
		
	}
}
