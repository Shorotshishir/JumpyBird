using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    private ScoreScriptable _scoreScriptable;

    [Header("Scores")]
    [SerializeField]
    private TextMeshProUGUI _currentScore;

    [SerializeField]
    private TextMeshProUGUI _highScore;

    [SerializeField]
    private TextMeshProUGUI _lastScore;

    private float count = 0;

    private void LateUpdate()
    {
        count += Time.deltaTime;
        _scoreScriptable.SetCurrentScore($"{count:N2}");
        _currentScore.text = $"High {_scoreScriptable.CurrentScore}";

        float.TryParse(_scoreScriptable.CurrentScore, out float current);
        float.TryParse(_scoreScriptable.HighScore, out float high);

        if (current > high)
        {
            _scoreScriptable.HighScore = current.ToString();
        }
        _highScore.text = $"High {_scoreScriptable.HighScore}";

        _lastScore.text = $"Last {_scoreScriptable.LastScore}";
    }
}