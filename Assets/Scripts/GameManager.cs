using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Fish Fish;

    public ScoreScriptable ScoreScriptable;

    private void OnEnable()
    {
        Fish.GameEnded += SwitchScene;
    }

    private void SwitchScene()
    {
        ScoreScriptable.SetLastScore();
        SceneManager.LoadScene(0);
    }
}