using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToScene : MonoBehaviour
{
    public string SceneName;
    

    public void ToScene()
    {
        Debug.Log("Loading scene " + SceneName + "...");
        SceneManager.LoadScene(SceneName);
        Time.timeScale = 1f;
        ScoreScript.ScoreNull();
    }

    public void ClearBS()
    {
        GameCore.Instance.ClearBestScore();
    }
    
}
