using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class CoinScript : MonoBehaviour
{
    public void Awake()
    {
  
    }

    private void Start()
    {
        Coins = GameCore.Instance.GetCoins();
        UpdateCoins();
    }

    public static int Coins;
    public GameObject Coin;
    public TextMeshProUGUI CoinsText;
    private float _timer;
    public float Period;
    private void FixedUpdate()
    {
        if(Time.time > _timer)
        { 
            _timer = Time.time + Period;
            var obj =  Instantiate(Coin);
            obj.transform.position = new Vector3(Random.Range(-2.7f, 2.7f), -10, 0);
        }
    }

    private void Update()
    {
        UpdateCoins();
    }
    
    public void UpdateCoins()
    {
        CoinsText.text = Convert.ToString(Coins);
    }
}
