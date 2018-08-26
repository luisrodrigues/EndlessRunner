using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public int score = 0;
    public Text scoreDisplay;
    public Player player;

    private void Update() {
        scoreDisplay.text = "Score: " + score.ToString();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Obstacle")) {
            if (player.health > 0) {
                score++;
            }
        }
    }
}
