using UnityEngine;

[CreateAssetMenu(fileName = "Score", menuName = "ScriptableObject/Score", order = 1)]
public class ScoreScriptable : ScriptableObject
{
    public string CurrentScore;

    public string LastScore;

    public string HighScore;

    private void OnEnable()
    {
        hideFlags = HideFlags.DontUnloadUnusedAsset;
    }

    public void SetLastScore()
    {
        LastScore = CurrentScore;
    }

    public void SetCurrentScore(string current)
    {
        CurrentScore = $"{current}";
    }

    public void Reset()
    {
        CurrentScore = string.Empty;
        LastScore = string.Empty;
        HighScore = string.Empty;
    }
}