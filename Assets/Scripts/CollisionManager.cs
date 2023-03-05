using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{

  void OnCollisionEnter(Collision other)
  {
    if (other.gameObject.CompareTag("Collectables") && !other.gameObject.GetComponentInChildren<Collectable>().isBomb)
    {
      GameManager.Game.points += other.gameObject.GetComponentInChildren<Collectable>().points;
      Destroy(other.gameObject);
    }
    else if (other.gameObject.GetComponentInChildren<Collectable>().isBomb)
    {
      Destroy(other.gameObject);
      GameManager.Game.GameOver();
    }
  }

}
