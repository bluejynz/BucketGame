using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

  public List<GameObject> balls;
  public GameObject bomb;
  public Vector3 originPoint = new Vector3(0, 15, 0);
  public int timeVariation = 3;
  public float interval = 1f;
  private float cooldown = 0f;

  void Update()
  {
    if (GameManager.Game.isGameOver)
    {
      ResetVariables();
      return;
    }
    cooldown -= Time.deltaTime;
    if (GameManager.Game.time % timeVariation == 0)
    {
      if (cooldown <= 0f)
      {
        SpawnBomb();
        interval -= .025f;
      }
    }
    if (cooldown <= 0f)
    {
      cooldown = interval;
      SpawnBall();
    }
  }

  void SpawnBall()
  {
    int prefabIndex = Random.Range(0, balls.Count);
    GameObject prefab = balls[prefabIndex];
    Quaternion rotation = prefab.transform.rotation;
    float gameWidth = GameManager.Game.gameWidth;
    float xOffset = Random.Range(-gameWidth / 2, gameWidth / 2);
    Vector3 position = originPoint + new Vector3(xOffset, 0, 0);
    Instantiate(prefab, position, rotation);
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

  void ResetVariables()
  {
    timeVariation = 3;
    interval = 1f;
    cooldown = 0f;
  }

}
