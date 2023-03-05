using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{

  void OnCollisionEnter(Collision other)
  {
    if(other.gameObject.CompareTag("Collectables")) {
      GameManager.Game.points += other.gameObject.GetComponentInChildren<Collectable>().points;
      Destroy(other.gameObject);
    }
  }

}
