using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreButton : MonoBehaviour
{
    public Button scoreButton;

    public Action<int> OnScoreChanged;

    public int score = 0;


    private void Awake()
    {
        scoreButton = GetComponent<Button>();

    }

    public void PointUp()
    {
        score++;
        OnScoreChanged?.Invoke(score);
    }
}
