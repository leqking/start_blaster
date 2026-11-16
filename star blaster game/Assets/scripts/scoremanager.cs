using UnityEngine;
using TMPro;
public class scoremanager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    int score = 0;
    void Start()
    {
        scoreText.text = "SCORE :" + score;
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "SCORE :" + score;
        if (score >= 12)
        {
            scoreText.text = "YOU WIN";
        }
    }
}
