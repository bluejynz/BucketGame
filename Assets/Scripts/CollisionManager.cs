using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{

  void OnCollisionEnter(Collision other)
  {
    if(other.gameObject.CompareTag("Collectables")) {
      
      // GameManager.Game.points += other.gameObject.GetComponent<Collectable>().points;
      Debug.Log("o outro objeto: " + other.gameObject.name);
      Destroy(other.gameObject);
    }
  }

}
