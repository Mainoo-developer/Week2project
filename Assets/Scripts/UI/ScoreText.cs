using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;

    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();

        scoreButton.OnScoreChanged += RefreshUI;

    }


    public void RefreshUI(int score)
    {
        scoreText.text = $"Score: {score}";
    }
}
