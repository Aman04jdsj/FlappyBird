using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text score;
    public GameObject gameOverScreen;
    public GameObject pauseScreen;
    private float timer = 0;
    public float levelUpTime = 5;

    public void addScore(int scoreDelta) {
        playerScore += scoreDelta;
        score.text = playerScore.ToString();
    }

    public void restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
    }

    public void quitGame() {
        Application.Quit();
    }

    public void levelUp() {
        Time.timeScale += 0.05f;
    }

    public void pause(bool isPaused) {
        pauseScreen.SetActive(isPaused);
    }

    void Update() {
        if (timer < levelUpTime) {
            timer += Time.deltaTime;
        } else {
            timer = 0;
            levelUp();
        }
    }
}
