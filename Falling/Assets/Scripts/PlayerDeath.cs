using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject Lose;
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Cloud" )
        {
            Time.timeScale = 0f;
            GameCore.Instance.SetBestScore(ScoreScript.score);
            Save();
            ScoreScript.score = 0;
            Lose.SetActive(true);
        }
        
        if(collision.gameObject.tag == "Lightning" )
        {
            Time.timeScale = 0f;
            GameCore.Instance.SetBestScore(ScoreScript.score);
            Save();
            ScoreScript.score = 0;
            Lose.SetActive(true);
        }
        
        if(collision.gameObject.tag == "WaterDrop" )
        {
            Time.timeScale = 0f;
            GameCore.Instance.SetBestScore(ScoreScript.score);
            Save();
            ScoreScript.score = 0;
            Lose.SetActive(true);
        }
    }


    public void Save()
    {
        GameCore.Instance.SetCoins(CoinScript.Coins);
    }
}
