using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

  public static GameManager Game { get; private set; }

  public float gameWidth = 20f;

  [HideInInspector]
  public bool isGameOver = false;

  [HideInInspector]
  public int highscore { get; private set; }

  [HideInInspector]
  public int points = 0;

  [HideInInspector]
  public int time = 60;

  void Awake()
  {
    if (Game != null && Game != this)
    {
      Destroy(this);
    }
    else
    {
      Game = this;
    }
  }

  void Update()
  {
    if (time <= 0)
    {
      GameOver();
    }
  }

  public void GameOver()
  {
    isGameOver = true;
    if (points > highscore)
    {
      highscore = points;
    }
  }

  public void PlayAgain()
  {
    points = 0;
    time = 60;
    isGameOver = false;
    StartCoroutine(TimerManager.Countdown());
  }

}
