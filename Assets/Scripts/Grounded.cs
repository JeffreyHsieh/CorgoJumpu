using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour {

    public PlayerControl player;
    void OnCollisionEnter2D(Collision2D collider)
    {
        player.readyToJump();
    }
}
