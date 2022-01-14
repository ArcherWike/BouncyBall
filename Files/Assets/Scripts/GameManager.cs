using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    int score;
    public Text ScoreText;
    public GameObject gameStartUI;

    private void Awake()
    {
        instance = this;
    }

    public void GameStart()
    {
        gameStartUI.SetActive(false);
        ScoreText.gameObject.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void ScoreUp()
    {
        score++;
        ScoreText.text = score.ToString();
    }
}
