using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
    private float playerScore = 0;

    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        playerScore += Time.deltaTime;
        ScoreText.text = ("Score: " + (int)(playerScore * 100));
    }

    public void increaseScore(int amount)
    {
        playerScore += amount;
    }
}
