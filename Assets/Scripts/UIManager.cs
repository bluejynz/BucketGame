using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

  public GameObject pointsText;
  public GameObject timerText;
  public GameObject gameOverMenu;
  public GameObject highscoreText;

  void Start()
  {
    gameOverMenu.SetActive(false);
  }

  void Update()
  {
    if(Input.GetKey(KeyCode.Escape)) {
      Quit();
    }
    if (GameManager.Game.isGameOver)
    {
      highscoreText.GetComponent<TextMeshProUGUI>().text = "Highscore: " + GameManager.Game.highscore;
      gameOverMenu.SetActive(true);
      return;
    }
    pointsText.GetComponent<TextMeshProUGUI>().text = "Points: " + GameManager.Game.points;
    timerText.GetComponent<TextMeshProUGUI>().text = GameManager.Game.time.ToString();
  }

  public void PlayAgain()
  {
    GameManager.Game.PlayAgain();
    gameOverMenu.SetActive(false);
  }

  public void Quit() {
    Application.Quit();
  }

}
