using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

  public Rigidbody2D body;

  Vector2 move;
  float moveLimiter = 0.75f;

  public float runSpeed = 0.5f;

  void Start() {
    body = GetComponent<Rigidbody2D>();
  }

  //Use for input
  void Update() {
    move.x = Input.GetAxisRaw("Horizontal");
    move.y = Input.GetAxisRaw("Vertical");
  }

  //Use for physics control
  private void FixedUpdate() {

    if (move.x != 0 && move.y != 0) {  // Check for diagonal movement
      // limit movement speed diagonally, so you move at 75% speed
      move.x *= moveLimiter;
      move.y *= moveLimiter;
    }
    body.velocity = new Vector2(move.x * runSpeed, move.y * runSpeed);

  }
}
