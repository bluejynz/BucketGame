using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

  public float speed = 10f;

  void Update()
  {
    bool isPressingLeft = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
    bool isPressingRight = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);

    if(isPressingLeft == isPressingRight || GameManager.Game.isGameOver) return;

    float movement = speed * Time.deltaTime;
    if(isPressingLeft) movement *= -1f;
    transform.position += new Vector3(movement, 0, 0);

    float movementLimit = GameManager.Game.gameWidth / 2;
    if(transform.position.x < -movementLimit) {
      transform.position = new Vector3(-movementLimit, transform.position.y, transform.position.z);
    } else if(transform.position.x > movementLimit) {
      transform.position = new Vector3(movementLimit, transform.position.y, transform.position.z);
    }
  }
}
