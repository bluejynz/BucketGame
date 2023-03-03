using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

  public static GameManager Game {get; private set;}

  public float gameWidth = 20f;

  void Awake() {
    if(Game != null && Game != this) {
      Destroy(this);
    } else {
      Game = this;
    }
  }

}
