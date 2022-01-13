using System;
using UnityEngine;


public class GameCore : MonoBehaviour
{

    public static GameCore Instance;


    public void Start()
    {
        //SetRainbow(0);
        //SetIcy(0);
        //SetCoins(50);
    }

    private void Awake()
    {
        
        if (Instance == null)
        {
            Debug.Log("I'm instance " + gameObject.name);
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }  
        else  
        {  
            Debug.Log("Instance already exist, harakiri " + gameObject.name);
            Destroy(gameObject);
           
        }

    }

    public void SetBestScore(int BestScore)
    {
        if (BestScore > GetBestScore())
        {
            PlayerPrefs.SetInt("BestScore", BestScore);
        }
    }
    public int GetBestScore()
    {
        return PlayerPrefs.GetInt("BestScore", 0);
    }
    public void ClearBestScore()
    {
        PlayerPrefs.SetInt("BestScore", 0);
        Debug.Log("Score was cleared");
    }
    
    
    
    

    public void SetCoins(int SetCoins)
    {
        PlayerPrefs.SetInt("SetCoins", SetCoins);
    }
    public int GetCoins()
    {
        return PlayerPrefs.GetInt("SetCoins", 0);
    }


    
    
    
    
    public void SetSkinNum(int SkinNum)
    {
        PlayerPrefs.SetInt("SkinNum", SkinNum);
    }
    public int GetSkinNum()
    {
        return PlayerPrefs.GetInt("SkinNum", 0);
    }
    
    
    
    
    //SKINS TRUE/FALSE
    

    public void SetRainbow(int Locked)
    {
        PlayerPrefs.SetInt("Locked", Locked);
    }
    public int GetRainbow()
    {
        return PlayerPrefs.GetInt("Locked", 0);
    }
    
    public void SetIcy(int Locked1)
    {
        PlayerPrefs.SetInt("Locked1", Locked1);
    }
    public int GetIcy()
    {
        return PlayerPrefs.GetInt("Locked1", 0);
    }

}
