using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamesManager : MonoBehaviour {

    public static GamesManager instance;

    public int score;
    public int highScore;

    public int lives = 3; //nyawa

    private void Awake() {
        instance = this;
    }

    void Start () {
        score = 0;
        highScore = PlayerPrefs.GetInt("highScore", 0);
	}
	
    public void addScore(int value) {
        score += value;
        Debug.Log("score: " + score);
    }

    public void decreaseLives(int value) {
        lives -= value;
        if (lives <= 0) gameOver();
    }

    public void gameOver() {
        Debug.Log("Game over()");
        if (score > highScore) {
            highScore = score;
            PlayerPrefs.SetInt("highScore", highScore);
        }
        GameResult.instance.Show();
        Debug.Log("score: " + score);
        Debug.Log("high score: " + highScore);
        Time.timeScale = 0;
    }
}
