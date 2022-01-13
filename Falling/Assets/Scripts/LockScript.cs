using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class LockScript : MonoBehaviour
{
    public GameObject Rainbow;
    public GameObject Icy;
    public int PriceR;
    public int PriceI;

    public void Awake()
    {
        if (GameCore.Instance.GetRainbow() == 1)
        {
            UnLocked(Rainbow);
        }
        if (GameCore.Instance.GetIcy() == 1)
        {
            UnLocked(Icy);
        }
    }
    public void UnLockR()
    {
        if (CoinScript.Coins >= PriceR)
        {
            CoinScript.Coins -= PriceR;
            GameCore.Instance.SetRainbow(1);
            Destroy(Rainbow);
            GameCore.Instance.SetCoins(CoinScript.Coins);
        }
    }
    public void UnLockI()
    {
        if (CoinScript.Coins >= PriceI)
        {
            CoinScript.Coins -= PriceI;
            GameCore.Instance.SetIcy(1);
            Destroy(Icy);
            GameCore.Instance.SetCoins(CoinScript.Coins);
        }
    }
    
    public void UnLocked(GameObject Obj)
    {
        Destroy(Obj);
    }
    
}
