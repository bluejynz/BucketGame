using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
  void Start()
  {
    StartCoroutine(Countdown());
  }

  void Update()
  {
  }

  public static IEnumerator Countdown()
  {
    while (GameManager.Game.time > 0 && !GameManager.Game.isGameOver)
    {
      GameManager.Game.time--;
      yield return new WaitForSeconds(1f);
    }
  }
}
