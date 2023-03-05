using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
  public bool isBomb;
  public int points;

  void Update()
  {
    if (GameManager.Game.isGameOver)
    {
      GameObject[] objs = GameObject.FindGameObjectsWithTag("Collectables");
      foreach(GameObject go in objs) {
        Destroy(go);
      }
    }
  }
}
