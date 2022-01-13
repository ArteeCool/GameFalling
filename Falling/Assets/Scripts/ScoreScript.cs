using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI ScoreTxt;
    public TextMeshProUGUI BestScoreTxt;
    private float _timer;
    public float Period;
    private void FixedUpdate()
    {
        if(Time.time > _timer)
        { 
            _timer = Time.time + Period;
            score = score + 1;
            ScoreTxt.text = Convert.ToString(score);
            BestScoreTxt.text = Convert.ToString(GameCore.Instance.GetBestScore());
        }
        
    }
    
    public void Start()
    {
        BestScoreTxt.text = Convert.ToString(GameCore.Instance.GetBestScore());
    }

    public static void ScoreNull()
    {
        score = 0;
    }
    
   
}
