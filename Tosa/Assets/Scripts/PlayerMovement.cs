using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public CharacterController2D controller;
    public float runSpeed = 40f;

    private float horizontalMovement;
    private bool jump = false;

    private void Update() {
        horizontalMovement = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump")) {
            jump = true;
        }
    }

    private void FixedUpdate() {
        controller.Move(horizontalMovement * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
