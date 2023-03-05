using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{

  public GameObject bomb;
  public Vector3 originPoint = new Vector3(0, 15, 0);
  public int variation = 3;
  public float interval = 1f;
  private float cooldown = 0f;

  void Update()
  {
    if(GameManager.Game.isGameOver) return;
    cooldown -= Time.deltaTime;
    if (GameManager.Game.time % variation == 0)
    {
      if (cooldown <= 0f)
      {
        cooldown = interval;
        SpawnBomb();
      }
    }
  }

  void SpawnBomb()
  {
    GameObject prefab = bomb.gameObject;
    Quaternion rotation = prefab.transform.rotation;
    float gameWidth = GameManager.Game.gameWidth;
    float xOffset = Random.Range(-gameWidth / 2, gameWidth / 2);
    Vector3 position = originPoint + new Vector3(xOffset, 0, 0);
    Instantiate(prefab, position, rotation);
  }

}
