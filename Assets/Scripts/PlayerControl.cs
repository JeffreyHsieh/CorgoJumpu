using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public int force;

    public void readyToJump()
    {
        playerStates = PlayerStates.Grounded;
    }

    enum PlayerStates {Grounded, Jumping, DoubleJumping};
    PlayerStates playerStates;

    void Start()
    {
        playerStates = PlayerStates.Grounded;
    }

	void FixedUpdate () {

        switch (playerStates)
        {
            case PlayerStates.Grounded:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
                    playerStates = PlayerStates.Jumping;
                }
                break;
            case PlayerStates.Jumping:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                    GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
                    playerStates = PlayerStates.DoubleJumping;
                }
                break;
        }
	}
}
