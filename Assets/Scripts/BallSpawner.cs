using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

  public List<GameObject> balls;
  public Vector3 originPoint = new Vector3(0, 15, 0);
  public float interval = 1f;
  private float cooldown = 0f;

  void Start()
  {

  }

  void Update()
  {
    cooldown -= Time.deltaTime;
    if (cooldown <= 0f)
    {
      cooldown = interval;
      SpawnBall();
    }
  }

  void SpawnBall() {
    int prefabIndex = Random.Range(0, balls.Count);
    GameObject prefab = balls[prefabIndex];
    Quaternion rotation = prefab.transform.rotation;
    float gameWidth = GameManager.Game.gameWidth;
    float xOffset = Random.Range(-gameWidth / 2, gameWidth / 2);
    Vector3 position = originPoint + new Vector3(xOffset, 0, 0);
    Instantiate(prefab, position, rotation);
  }

}
