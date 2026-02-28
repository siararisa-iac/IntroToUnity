using TMPro;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
  
    private void Start()
    {
        if (scoreText == null)
        {
            scoreText = GetComponent<TextMeshProUGUI>();
        }
    }

    private void Update()
    {
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = $"Score: {ScoreManager.Instance.CurrentScore}";
    }
}
