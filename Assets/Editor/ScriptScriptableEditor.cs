using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ScoreScriptable))]
public class ScriptScriptableEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        var myscript = (ScoreScriptable)target;
        if (GUILayout.Button("Reset"))
        {
            myscript.Reset();
        }
    }
}